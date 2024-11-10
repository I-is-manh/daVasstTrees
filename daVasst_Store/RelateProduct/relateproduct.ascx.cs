using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.RelateProduct
{
    public partial class relateproduct : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            productDao dao = new productDao();
            if (Request.Params["categoryID"] != null && Request.Params["productID"] != null)
            {
                int categoryID = int.Parse(Request.Params["categoryID"]);
                int productID = int.Parse(Request.Params["productID"]);
                List<Product> list = dao.getProductByCategoryID(categoryID,productID);
                string str = "";
                foreach(Product p in list)
                {
                    if(p.DiscountPercent == 0)
                    {
                       str += $"<div class=\"relateproduct-item\" productID={p.ProductID} categoryID={p.CategoryID}>\r\n " +
                       $"<div class=\"relateproduct-item__surro\">\r\n" +
                       $"<img src={p.LinkImg} alt=\"Alternate Text\" class=\"relateproduct-item__surro-img\" />\r\n " +
                       $"</div>\r\n " +
                       $"<div class=\"relateproduct-item-info\">\r\n" +
                       $"<p class=\"relateproduct-item-info__name\">{p.Name}</p>\r\n " +
                       $"<p class=\"relateproduct-item-info__price\">{p.Price.ToString("#,##")}đ</p>\r\n " +
                       $"<button class=\"relateproduct-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n " +
                       $"</div>\r\n" +
                       $"</div>";
                    }
                    else
                    {
                        float oldPrice = p.Price + (p.Price * p.DiscountPercent / 100);
                        str += $"<div class=\"relateproduct-item\" productID={p.ProductID} categoryID={p.CategoryID}>\r\n" +
                            $"<div class=\"relateproduct-item__surro\">\r\n " +
                            $"<img src={p.LinkImg} alt=\"Alternate Text\" class=\"relateproduct-item__surro-img\" />\r\n " +
                            $"</div>\r\n " +
                            $"<div class=\"relateproduct-item-info\">\r\n " +
                            $"<p class=\"relateproduct-item-info__name\">{p.Name}</p>\r\n " +
                            $"<p class=\"relateproduct-item-info__dash\">{oldPrice.ToString("#,##")}đ</p>\r\n  " +
                            $"<p class=\"relateproduct-item-info__price\">{p.Price.ToString("#,##")}đ</p>\r\n " +
                            $"<button class=\"relateproduct-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n " +
                            $"</div>\r\n " +
                            $" </div>";
                    }
                }
                relateProduct.InnerHtml = str;
            }

        }
    }
}