using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.productDetail
{
    public partial class productDetail : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            productDao dao = new productDao();
            Product p = new Product();
            if (Request.Params["productID"] != null)
            {
                string str = "";
                int productID = int.Parse(Request.Params["productID"]);
                p = dao.getProductById(productID);
                if (p.DiscountPercent != 0)
                {
                    float oldPrice = p.Price + (p.Price * p.DiscountPercent / 100);
                        str = $"<div class=\"productDetail-item\" productID={p.ProductID} categoryID={p.CategoryID}>\r\n" +
                        $" <div class=\"productDetail-item-imgSurro\">\r\n " +
                        $"<img src={p.LinkImg} alt=\"Alternate Text\" class=\"productDetail-item-imgSurro__img\"/>\r\n " +
                        $" </div>\r\n " +
                        $" <div class=\"productDetail-item-infomation\">\r\n " +
                        $" <div class=\"productDetail-item-infomation__breadcrumb\">\r\n" +
                        $"<a href=\"#\">Trang chủ</a>\r\n" +
                        $" <span>/</span>\r\n" +
                        $"<a href=\"#\">Cây để bàn</a>\r\n " +
                        $"<span>/</span>\r\n " +
                        $" <a href=\"#\">{p.Name}</a>\r\n" +
                        $" </div>\r\n " +
                        $" <p class=\"productDetail-item-infomation__name\">{p.Name}</p>\r\n" +
                        $" <div class=\"productDetail-item-infomation-price\">\r\n" +
                        $"<p class=\"productDetail-item-infomation-price__oldPrice\">{oldPrice.ToString("#,##")}đ</p>\r\n" +
                        $" <p class=\"productDetail-item-infomation-price__currentPrice\">{p.Price.ToString("#,##")}đ</p>\r\n" +
                        $"</div>\r\n " +
                        $"<p class=\"productDetail-item-infomation__description\">{p.Desc}</p>\r\n" +
                        $"<div class=\"productDetail-item-infomation-btnAdd\">\r\n  " +
                        $"<div class=\"productDetail-item-infomation-btnAdd__Addnumber\">\r\n   " +
                        $" <span>-</span>" +
                        $" <span>1</span>" +
                        $" <span>+</span>" +
                        $"</div>\r\n" +
                        $"<button class=\"productDetail-item-infomation-btnAdd__btnAddCart btnAll\"><a href=\"cart.aspx?productID={p.ProductID}&categoryID={p.CategoryID}\">Thêm vào giỏ hàng</a></button>\r\n " +
                        $" </div>\r\n  " +
                        $"<button class=\"productDetail-item-infomation__buynow\"><a href=\"cart.aspx?productID={p.ProductID}&categoryID={p.CategoryID}&buynow=true\">Mua hàng ngay</a></button>\r\n " +
                        $"</div>\r\n" +
                        $"</div>";
                }
                else
                {
                        str = $"<div class=\"productDetail-item\" productID={p.ProductID} categoryID={p.CategoryID}>\r\n" +
                        $" <div class=\"productDetail-item-imgSurro\">\r\n " +
                        $"<img src={p.LinkImg} alt=\"Alternate Text\" class=\"productDetail-item-imgSurro__img\"/>\r\n " +
                        $" </div>\r\n " +
                        $" <div class=\"productDetail-item-infomation\">\r\n " +
                        $" <div class=\"productDetail-item-infomation__breadcrumb\">\r\n" +
                        $"<a href=\"#\">Trang chủ</a>\r\n" +
                        $" <span>/</span>\r\n" +
                        $"<a href=\"#\">Cây để bàn</a>\r\n " +
                        $"<span>/</span>\r\n " +
                        $" <a href=\"#\">{p.Name}</a>\r\n" +
                        $" </div>\r\n " +
                        $" <p class=\"productDetail-item-infomation__name\">{p.Name}</p>\r\n" +
                        $" <div class=\"productDetail-item-infomation-price\">\r\n" +
                        $" <p class=\"productDetail-item-infomation-price__currentPrice\">{p.Price.ToString("#,##")}đ</p>\r\n" +
                        $"</div>\r\n " +
                        $"<p class=\"productDetail-item-infomation__description\">{p.Desc}</p>\r\n" +
                        $"<div class=\"productDetail-item-infomation-btnAdd\">\r\n  " +
                        $"<div class=\"productDetail-item-infomation-btnAdd__Addnumber\">\r\n   " +
                        $" <span>-</span>\r\n    " +
                        $" <span>1</span>\r\n " +
                        $" <span>+</span>\r\n " +
                        $"</div>\r\n" +
                        $"<button class=\"productDetail-item-infomation-btnAdd__btnAddCart btnAll\"><a href=\"cart.aspx?productID={p.ProductID}&categoryID={p.CategoryID}\">Thêm vào giỏ hàng</a></button>\r\n " +
                        $" </div>\r\n  " +
                        $"<button class=\"productDetail-item-infomation__buynow\"><a href=\"cart.aspx?productID={p.ProductID}&categoryID={p.CategoryID}&buynow=true\">Mua hàng ngay</a></button>\r\n " +
                        $"</div>\r\n" +
                        $"</div>";
                }
                productDetaill.InnerHtml = str;
            }
        }
    }
}
