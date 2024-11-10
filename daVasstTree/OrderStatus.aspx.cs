using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstTree
{
    public partial class OrderStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userOrder"] == null)
            {
                orderStatus.InnerHtml = $"<h1 class=\"orderStatus-product__title\">Bạn chưa có đơn hàng nào</h1>";
            }
            else
            {
                List<CartProduct> listCart = (List<CartProduct>)Session["cartList"];
                UserInfomationOrder infoOrder = (UserInfomationOrder)Session["infoOrder"];
                float total = 0;
                string str = $"<h1 class=\"orderStatus-product__title\">Chi tiết đơn hàng của bạn</h1>" +
                    $"<div class=\"orderStatus-product__item\"><span>Sản phẩm</span><span>Tổng</span></div>";
                foreach(CartProduct x in listCart)
                {
                    str += $"<div class=\"orderStatus-product__item\"><span>{x.Product.Name} x {x.Quantity}</span><span>{(x.Product.Price*x.Quantity).ToString("#,### đ")}</span></div>";
                    total += x.Product.Price * x.Quantity;
                }
                    
                    str += $" <div class=\"orderStatus-product__item\"><span>Ngay</span><span>{infoOrder.DateOrder}</span></div>" +
                    $"<div class=\"orderStatus-product__item\"><span>Phương thức thanh toán</span><span>{infoOrder.PTTT}</span></div>" +
                    $"<div class=\"orderStatus-product__item\"><span>Tổng</span><span>{total.ToString("#,### đ")}</span></div>" +
                    $"<button class=\"btnAll\"><a href=\"Home.aspx\"><img src=\"../Image/arrow-left-line.png\" alt=\"Alternate Text\" /> Quay về trang chủ</a></button>";
                orderStatus.InnerHtml = str;
            }
        }
    }
}