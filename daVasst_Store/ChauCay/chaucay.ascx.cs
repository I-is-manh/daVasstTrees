﻿using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.ChauCay
{
    public partial class chaucay : System.Web.UI.UserControl
    {
        productDao dao = new productDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> list = dao.getListProduct("chaucay");
            string str = "";
            foreach (Product x in list)
            {
                if (x.DiscountPercent == 0)
                {
                    str += $"<div class=\"listChauCay__item\">\r\n " +
                    $"<div class=\"listChauCay__item-imgSuro\">\r\n      " +
                    $" <img src={x.LinkImg} alt={x.Name} class=\"listChauCay__item-imgSuro-img\" />\r\n                " +
                    $"</div>\r\n   " +
                    $"<div class=\"listChauCay-item-info\">\r\n               " +
                    $"<p class=\"listChauCay-item-info__name\">{x.Name}</p>\r\n                    " +
                    $"<p class=\"listChauCay-item-info__price\">{x.Price.ToString("#,## đ")}</p>\r\n                    " +
                    $"<button class=\"listChauCay-item-info__btn\"><a href=\"cart.aspx?id={x.ProductID}\">Thêm vào giỏ hàng</a></button>\r\n         " +
                    $" </div>\r\n  </div>";
                }
                else
                {
                    float oldPrice = x.Price + (x.Price * x.DiscountPercent / 100);
                    str += $"<div class=\"listChauCay__item\">\r\n" +
                        $"<div class=\"listChauCay__item-imgSuro\">\r\n " +
                        $"<img src={x.LinkImg} alt={x.Name} class=\"listChauCay__item-imgSuro-img\" />\r\n </div>\r\n " +
                        $"<div class=\"listChauCay-item-info\">\r\n  <p class=\"listChauCay-item-info__name\">{x.Name}</p>\r\n " +
                        $"<span class=\"listChauCay-item-info__dash\">{oldPrice.ToString("#,## đ")}</span>\r\n  <span class=\"listChauCay-item-info__price\">{x.Price.ToString("#,## đ")}</span>\r\n " +
                        $" <button class=\"listChauCay-item-info__btn\"><a href=\"cart.aspx?id={x.ProductID}\">Thêm vào giỏ hàng</a></button>" +
                        $"</div>" +
                        $" <span class=\"listChauCay__item-discount\">{x.DiscountPercent} %</span>\r\n</div>";
                }
            }
            listChauCay.InnerHtml = str;
        }
    }
}