using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.productListItem
{
    public partial class productListItem : System.Web.UI.UserControl
    {
        categoryDao category = new categoryDao();
        productDao product = new productDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();
            
            if (Request.QueryString["id"] != null)
            {
                string str = "";
                int id = int.Parse(Request.QueryString["id"]);
                Categoryy c = category.getInfoCategory(id);
                list = product.getListProduct(c.Code);
                listTreeTitle.InnerText = c.Name;
                foreach(Product x in list)
                {
                    if (x.DiscountPercent == 0)
                    {
                        str += $"<div class=\"listTrees-item\">\r\n" +
                            $"<div class=\"listTrees-item__surro\">\r\n" +
                            $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n" +
                            $"</div>\r\n            <div class=\"listTrees-item-info\">\r\n" +
                            $"<p class=\"listTrees-item-info__name\">{x.Name}</p>\r\n" +
                            $"<p class=\"listTrees-item-info__price\">{x.Price} đ</p>\r\n" +
                            $"<button class=\"listTrees-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n " +
                            $"</div>\r\n" +
                            $"</div>";
                    }
                    else
                    {
                        float oldPrice = x.Price + (x.Price * x.DiscountPercent / 100);
                        str += $"<div class=\"listTrees-item\">\r\n" +
                            $"<div class=\"listTrees-item__surro\">\r\n " +
                            $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n " +
                            $" </div>\r\n " +
                            $" <div class=\"listTrees-item-info\">\r\n " +
                            $"<p class=\"listTrees-item-info__name\">{x.Name}</p>\r\n  " +
                            $" <span class=\"listTrees-item-info__dash\">{oldPrice} đ</span>\r\n  " +
                            $" <span class=\"listTrees-item-info__price\">{x.Price} đ</span>\r\n " +
                            $"<button class=\"listTrees-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n" +
                            $" </div>\r\n " +
                            $" </div>";
                    }
                }
                listTrees.InnerHtml = str;
            }
            else
            {
                string str = "";
                listTreeTitle.InnerText = "Tất cả sản phẩm";
                list = product.getListProduct("");
                foreach (Product x in list)
                {
                    if (x.DiscountPercent == 0)
                    {
                        str += $"<div class=\"listTrees-item\">\r\n" +
                            $"<div class=\"listTrees-item__surro\">\r\n" +
                            $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n" +
                            $"</div>\r\n            <div class=\"listTrees-item-info\">\r\n" +
                            $"<p class=\"listTrees-item-info__name\">{x.Name}</p>\r\n" +
                            $"<p class=\"listTrees-item-info__price\">{x.Price} đ</p>\r\n" +
                            $"<button class=\"listTrees-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n " +
                            $"</div>\r\n" +
                            $"</div>";
                    }
                    else
                    {
                        float oldPrice = x.Price + (x.Price * x.DiscountPercent / 100);
                        str += $"<div class=\"listTrees-item\">\r\n" +
                            $"<div class=\"listTrees-item__surro\">\r\n " +
                            $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n " +
                            $" </div>\r\n " +
                            $" <div class=\"listTrees-item-info\">\r\n " +
                            $"<p class=\"listTrees-item-info__name\">{x.Name}</p>\r\n  " +
                            $" <span class=\"listTrees-item-info__dash\">{oldPrice} đ</span>\r\n  " +
                            $" <span class=\"listTrees-item-info__price\">{x.Price} đ</span>\r\n " +
                            $"<button class=\"listTrees-item-info__btn\"><a href=\"#\">Thêm vào giỏ hàng</a></button>\r\n" +
                            $" </div>\r\n " +
                            $" </div>";
                    }
                }
                listTrees.InnerHtml = str;
            }
        }
    }
}