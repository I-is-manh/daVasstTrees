﻿using daVasstTrees.DAO;
using daVasstTrees.daVasst_Store.productListItem;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        categoryDao category = new categoryDao();
        productDao product = new productDao();
        public static string getProduct(List<Product> list)
        {
            string str = "";

            foreach (Product x in list)
            {
                if (x.DiscountPercent == 0)
                {
                    str += $"<div class=\"listTrees-item\" productID={x.ProductID} categoryID={x.CategoryID}>\r\n" +
                        $"<div class=\"listTrees-item__surro\">\r\n" +
                        $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n" +
                        $"</div>\r\n            <div class=\"listTrees-item-info\">\r\n" +
                        $"<p class=\"listTrees-item-info__name\">{x.Name}</p>\r\n" +
                        $"<p class=\"listTrees-item-info__price\">{x.Price.ToString("#,##")} đ</p>\r\n" +
                        $"<div>" +
                        $"<button class=\"btnAll\"><a href=\"productDetailAdmin.aspx?id={x.ProductID}\">Sửa</a></button>" +
                        $"<button class=\"btnAll\"><a href=\"removeProduct.aspx?id={x.ProductID}\">Xóa</a></button>" +
                        $"</div>" +
                        $"</div>\r\n" +
                        $"</div>";
                }
                else
                {
                    float oldPrice = x.Price + (x.Price * x.DiscountPercent / 100);
                    str += $"<div class=\"listTrees-item\" productID={x.ProductID} categoryID={x.CategoryID}>\r\n" +
                        $"<div class=\"listTrees-item__surro\">\r\n " +
                        $"<img src={x.LinkImg} alt=\"Alternate Text\" class=\"listTrees-item__surro-img\" />\r\n " +
                        $" </div>\r\n " +
                        $" <div class=\"listTrees-item-info\">\r\n " +
                        $"<p class=\"listTrees-item-info__name listTrees-item-info__notmargin\">{x.Name}</p>\r\n  " +
                        $" <span class=\"listTrees-item-info__dash\">{oldPrice.ToString("#,##")} đ</span>\r\n  " +
                        $" <span class=\"listTrees-item-info__price\">{x.Price.ToString("#,##")} đ</span>\r\n " +
                        $"<div>" +
                        $"<button class=\"btnAll\"><a href=\"productDetailAdmin.aspx?id={x.ProductID}\">Sửa</a></button>" +
                        $"<button class=\"btnAll\"><a href=\"removeProduct.aspx?id={x.ProductID}\">Xóa</a></button>" +
                        $"</div>" +
                        $" </div>\r\n " +
                        $" </div>";
                }
            }
            return str;
        }
        public static string getPaginationNumber(List<Product> list, string id, int pageNow)
        {
            string str = "<img src=\"../../Image/arrow-left-line.png\" alt=\"Alternate Text\" class=\"lisstressparent-pagination__list-img\"/>";
            double n = 0;
            if (list.Count >= 8)
            {
                n = (double)list.Count / 8;
                n = Math.Ceiling(n);
            }
            else
            {
                n = (double)list.Count / 8;
                n = Math.Ceiling(n) + 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (id == "")
                {
                    if (i != pageNow)
                    {
                        str += $"<span  class=\"lisstressparent-pagination__list-item\"><a href=\"ListProduct.aspx?page={i}\">{i}</a></span>";
                    }
                    else
                    {
                        str += $"<span  class=\"lisstressparent-pagination__list-item activePage\"><a href=\"ListProduct.aspx?page={i}\">{i}</a></span>";
                    }
                }
                else
                {
                    if (i != pageNow)
                    {
                        str += $"<span  class=\"lisstressparent-pagination__list-item\"><a href=\"ListProduct.aspx?id={id}&page={i}\">{i}</a></span>";
                    }
                    else
                    {
                        str += $"<span  class=\"lisstressparent-pagination__list-item activePage\"><a href=\"ListProduct.aspx?id={id}&page={i}\">{i}</a></span>";
                    }
                }
            }
            str += "<img src=\"../../Image/arrow-right-line.png\" alt=\"Alternate Text\" class=\"lisstressparent-pagination__list-img\"/>";
            return str;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageNow = 1;
            string id = "1";
            List<Product> list = new List<Product>();
            List<Product> allProduct = new List<Product>();
            string gia = "";
            if (Request.QueryString["page"] != null)
            {
                pageNow = int.Parse(Request.QueryString["page"].ToString());
            }
            if (Request.QueryString["id"] != null)
            {
                id = Request.QueryString["id"];
                Categoryy c = category.getInfoCategory(int.Parse(id));
                list = product.getListProductpagination(c.Code, pageNow,gia);
                allProduct = product.getListProduct(c.Code);
                listTreeTitle.InnerText = c.Name;
                listTrees.InnerHtml = WebForm1.getProduct(list);
                WebForm1.getProduct(list);
                pageList.InnerHtml = WebForm1.getPaginationNumber(allProduct, c.Code, pageNow);
            }
            else if (Request.QueryString["key"] != null)
            {
                string keySearch = Request.Params["key"];
                listTreeTitle.InnerText = "Sản phẩm bạn tìm kiếm";
                list = product.getSearchProductPagination(keySearch, pageNow,gia);
                listTrees.InnerHtml = WebForm1.getProduct(list);
                pageList.InnerHtml = WebForm1.getPaginationNumber(product.getSearchProductAll(keySearch), "", pageNow);
            }
            else
            {
                listTreeTitle.InnerText = "Tất cả sản phẩm";
                list = product.getListProductpagination("", pageNow,gia);
                allProduct = product.getListProduct("");
                listTrees.InnerHtml = WebForm1.getProduct(list);
                pageList.InnerHtml = WebForm1.getPaginationNumber(allProduct, "", pageNow);
            }
        }
    }
}