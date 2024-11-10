using daVasstTrees.DAO;
using daVasstTrees.daVasstTree;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.CartDetail
{
    public partial class cartDetail : System.Web.UI.UserControl
    {
        public static productDao dao = new productDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["productID"] == null && Request.Params["categoryID"] == null)
            {
                dataBind();
            }
            else
            {
                if (!IsPostBack)
                {
                    if (Request.Params["productID"] != null && Request.Params["categoryID"] != null)
                    {
                        int productID = int.Parse(Request.Params["productID"]);
                        int categoryID = int.Parse(Request.Params["categoryID"]);
                        Product product = dao.getProductById(productID);
                        if (Request.Params["buynow"] != null)
                        {
                            CartProduct cart = new CartProduct(product, 1);
                            List<CartProduct> sessionEmpty = new List<CartProduct>();
                            sessionEmpty.Add(cart);
                            Session["cartList"] = sessionEmpty;
                            dataBind();
                        }
                        else if (Session["cartList"] == null)
                        {
                            Product p = dao.getProductById(productID);
                            CartProduct cart = new CartProduct(p, 1);
                            List<CartProduct> sessionEmpty = new List<CartProduct>();
                            sessionEmpty.Add(cart);
                            Session["cartList"] = sessionEmpty;
                            Response.Redirect(Request.UrlReferrer.ToString());
                        }
                        else
                        {
                            List<CartProduct> list = (List<CartProduct>)Session["cartList"];
                            bool checkexist = false;
                            foreach (CartProduct x in list)
                            {
                                if (x.Product.ProductID == productID)
                                {
                                    checkexist = true;
                                }
                            }
                            if (checkexist == false)
                            {
                                addToCart(productID);
                            }
                            else
                            {
                                updataCartExist(productID);
                            }
                            Response.Redirect(Request.UrlReferrer.ToString());
                        }
                       
                        
                    }
                    
                    
                }
                
            }
            
        }
        public void dataBind()
        {
            List<CartProduct> list = new List<CartProduct>();
            if (Session["cartList"] != null)
            {
                list = (List<CartProduct>)Session["cartList"];
            }
           if(list.Count != 0)
           {
                cartRepeater.DataSource = list;
                cartRepeater.DataBind();
           }
           else
           {
                cartDetailList.InnerHtml = "<p class=\"cartempty\">Giỏ hàng của bạn chưa có sản phẩm</p>";
           }
           totalprice.InnerHtml = getTotalPrice().ToString("#,## đ");
        }
        protected void btnTru_Click(object sender, EventArgs e)
        {
            updateCart(int.Parse(Request.Form["tru"]), '-');
        }
        protected void btnCong_Click(object sender, EventArgs e)
        {
            updateCart(int.Parse(Request.Form["cong"]), '+');

        }

        protected void remove_Click(object sender, EventArgs e)
        {
            List<CartProduct> listCart = (List<CartProduct>)Session["cartList"];
            List<CartProduct> listRemove = new List<CartProduct>();
            int productID = int.Parse(Request.Form["remove"]);
            foreach(CartProduct x in listCart)
            {
                if(x.Product.ProductID != productID)
                {
                    listRemove.Add(x);
                }

            }
            Session["cartList"] = listRemove;
            dataBind();
        }
        public static void addToCart(int productid)
        {
            Product product = dao.getProductById(productid);
            CartProduct cartProdcut = new CartProduct(product,1);
            List<CartProduct> list = (List<CartProduct>)HttpContext.Current.Session["cartList"];
            list.Add(cartProdcut);
            HttpContext.Current.Session["cartList"] = list;
            
        }
        public static void updataCartExist(int productID)
        {
            List<CartProduct> list = (List<CartProduct>)HttpContext.Current.Session["cartList"];
            foreach(CartProduct x in list)
            {
                if(x.Product.ProductID == productID)
                {
                    x.Quantity++;
                }
            }
            HttpContext.Current.Session["cartList"] = list;
        }
        public void updateCart(int productID,char opeator)
        {
            List<CartProduct> listCart = (List<CartProduct>)Session["cartList"];
            foreach(CartProduct x in listCart)
            {
                if(x.Product.ProductID == productID)
                {
                    if(opeator == '+')
                    {
                        x.Quantity = x.Quantity + 1;
                    }
                    else
                    {
                        x.Quantity = x.Quantity - 1;
                    }
                }
            }
            Session["cartList"] = listCart;
            dataBind();
        }
        protected void rptCartItems_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                // Lấy dữ liệu từ nguồn (ví dụ: từ object CartItem)
                CartProduct item = (CartProduct)e.Item.DataItem;

                // Tính tổng số tiền
                float totalAmount = item.Product.Price * item.Quantity;

                // Gán tổng số tiền vào một Label hoặc Literal để hiển thị lên giao diện
                Label lblTotal = (Label)e.Item.FindControl("lblTotal");
                lblTotal.Text = totalAmount.ToString("#,##0 đ");
                HtmlButton btnCong = (HtmlButton)e.Item.FindControl("btnCong");
                btnCong.Attributes.Add("value", item.Product.ProductID.ToString());
                HtmlButton btnRemove = (HtmlButton)e.Item.FindControl("remove");// tạo một html button
                btnRemove.Attributes.Add("value", item.Product.ProductID.ToString());
                HtmlButton btnTru = (HtmlButton)e.Item.FindControl("btnTru");
                btnTru.Attributes.Add("value", item.Product.ProductID.ToString());

            }   
        }
        public  float getTotalPrice()
        {
            if (Session["cartList"] != null)
            {
                List<CartProduct> listCart = (List<CartProduct>)Session["cartList"];
                float total = 0;
                foreach (CartProduct x in listCart)
                {
                    total += x.Product.Price * x.Quantity;
                }
                return total;
            }
            else
            {
                return 0;
            }
        }
    }
}