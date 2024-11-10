using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class productDetailAdmin : System.Web.UI.Page
    {
        public static string rederData(Product product)
        {
            
            string str = $"<div class=\"productAdmin-detail-updateimg\">" +
                $"<div class=\"productAdmin-detail-updateimg__img\">" +
                $"<img src=\"{product.LinkImg}\" alt=\"Alternate Text\" id=\"imgavt\" />" +
                $" <div class=\"productAdmin-detail-updateimg__camera\">" +
                $"<img src=\"../../Image/camera.jpg\" alt=\"Alternate Text\" />" +
                $"<input type=\"file\" name=\"uploadfile\" value=\"{product.LinkImg}\" id=\"inputfile\" />" +
                $" </div>" +
                $"</div>" +
                $"<p>{product.Name}</p>" +
                $"</div>" +
                $"<div class=\"productAdmin-info\">" +
                $"<div class=\"productAdmin-info-item\">" +
                $"<label>Tên sản phẩm</label>" +
                $"<input type=\"text\" name=\"name\" value=\"{product.Name}\" id=\"nameproduct\"/>" +
                $"<label id=\"errorName\" style=\"color:red\"></label>"+
                $"</div>" +
                $" <div class=\"productAdmin-info-item\">" +
                $"<label>Giá</label>" +
                $"<input type=\"text\" name=\"price\" value=\"{(product.Price).ToString("#,### ")}\" oninput=\"formatCurrency(this)\" id=\"priceproduct\"/>" +
                $"<label id=\"errorPrice\" style=\"color:red\"></label>" +
                $" </div>" +
                $"<div class=\"productAdmin-info-item\">" +
                $"<label>Phần trăm giảm giá tính theo số nguyên</label>" +
                $"<input type=\"text\" name=\"discount\" value=\"{product.DiscountPercent}\" id=\"discountproduct\"/>" +
                $"<label id=\"errorDiscount\" style=\"color:red\"></label>" +
                $"</div>" +
                $"<div class=\"productAdmin-info-item\">" +
                $"<label>Số lượng</label>" +
                $" <input type=\"text\" name=\"quantity\" value=\"{product.Quantity}\" id=\"quantityproduct\"/>" +
                $"<label id=\"errorQuantity\" style=\"color:red\"></label>" +
                $" </div>" +
                $"<div class=\"productAdmin-info-item\">" +
                $"<label>Mô tả sản phẩm</label>" +
                $"<input type=\"text\" name=\"desc\" value=\"{product.Desc}\" id=\"descproduct\"/>" +
                $"<label id=\"errorDesc\" style=\"color:red\"></label>" +
                $" </div>" +
                $"</div>" +
                $"<input type=\"submit\" class=\"btnAll\" value=\"Cập nhật\">";
           
            return str;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            productDao dao = new productDao();
            Product product = new Product();
            int id = 1;
            if (Request.QueryString["id"] != null)
            {
                id = int.Parse(Request.QueryString["id"]);
                Session["idProduct"] = id;
            }
            product = dao.getProductById(int.Parse(Session["idProduct"].ToString()));
            if (IsPostBack)
            {
                string linkimg;
                if (Request.Files["uploadfile"].FileName != "")
                {
                    linkimg = "../../Image/" + Request.Files["uploadfile"].FileName;
                }
                else
                {
                    linkimg = product.LinkImg;
                }
                string name = Request.Form["name"];
                string price = Request.Form["price"];
                string discount = Request.Form["discount"];
                string quantity = Request.Form["quantity"];
                string desc = Request.Form["desc"];
                price = price.Replace(".", "");
                if (dao.updateProduct(id, name, price, discount, quantity, linkimg, desc) == true)
                {
                    overlay.Attributes.Add("class", "overlay-show");
                }
                //dao.updateProduct(int.Parse(Session["idProduct"].ToString()), name, price, discount, quantity, linkimg, desc);
                //overlay.Attributes.Add("class", "overlay-show");
            }
            //product = dao.getProductById(int.Parse(Session["idProduct"].ToString()));
            productAdmin.InnerHtml = productDetailAdmin.rederData(product);
        }
    }
}