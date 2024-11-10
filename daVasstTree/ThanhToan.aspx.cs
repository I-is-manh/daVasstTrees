using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstTree
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        User user = new User();
        userDao dao = new userDao();
        orderDao orderdao = new orderDao();
        orderDetailDao orderDetailDao = new orderDetailDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.Form["giamgia"]);
            if (Session["checkdn"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                bindInfomationUser();
                bindCartList();
            }
            if (IsPostBack)
            {
                string fullname = Request.Form["fullname"];
                string address = Request.Form["address"];
                string numberphone = Request.Form["numberphone"];
                string email = Request.Form["email"];
                string moreinfo = Request.Form["moreinfo"];
                string dateOrder = DateTime.Now.ToString("dd-MM-yyyy");
                if (moreinfo == "")
                {
                    moreinfo = null;
                }
                string pttt = Request.Form["pttt"];
                string pt = "";
                if(pttt == "nh")
                {
                    pt = " Chuyển khoản ngân hàng";
                }
                else
                {
                    pt = "Thanh toán khi nhận hàng";
                }
                UserInfomationOrder userorder = new UserInfomationOrder(fullname, address, numberphone, email, moreinfo,dateOrder,pt);
                Session["infoOrder"] = userorder;
                List<CartProduct> list = (List<CartProduct>)Session["cartList"];
                string emailDN = Request.Cookies["taikhoandn"]["tk"];
                string password = Request.Cookies["taikhoandn"]["mk"];
                user = dao.getInfomation(emailDN, password);
                
                bool checkInsertOrder = orderdao.inserData(user.GetCustomerID(), address, pt, numberphone, moreinfo);
                int orderID = orderdao.getOrderID(user.GetCustomerID());
                bool checkInsertOrderDetail = orderDetailDao.insertData(orderID, list);
                if (checkInsertOrder == true && checkInsertOrderDetail ==true)
                {
                    Response.Redirect("confirmpay.aspx");
                }
            }

        }
        public void bindInfomationUser()
        {
            string email = Request.Cookies["taikhoandn"]["tk"];
            string password = Request.Cookies["taikhoandn"]["mk"];
            user = dao.getInfomation(email, password);
            string str = "<h1 class=\"pay-info__title\">Thông tin thanh toán</h1>";
            str += $"<div class=\"pay-info-fullname pay-info-item\">" +
                $"<label class=\"pay-info-fullname__label\">" +
                $" Họ và tên* :" +
                $"</label>" +
                $"<input type=\"text\" name=\"fullname\" value=\"{user.GetFullName()}\" class=\"pay-info-fullname__inp\" id=\"fullname\" required />" +
                $"<label style=\"color:red\" id=\"errorFullname\"></label>" +
                $"</div>" +
                $"<div class=\"pay-info-address pay-info-item\">" +
                $"<label class=\"pay-info-address__label\">Địa chỉ giao hàng</label>" +
                $" <input type=\"text\" name=\"address\" value=\"{user.GetAddress()}\" id=\"address\" class=\"pay-info-address__inp\" required />" +
                $"<label style=\"color:red\" id=\"errorAddress\"></label>" +
                $"</div>" +
                $"<div class=\"pay-info-numberphone pay-info-item\">" +
                $" <label class=\"pay-info-numberphone__label\">Số điện thoại</label>" +
                $"<input type=\"text\" name=\"numberphone\" id=\"numberphone\" value=\"{user.GetNumberphone()}\" class=\"pay-info-numberphone__inp\" required />" +
                $"<label id=\"errorNumberphone\" style=\"color: red;\"></label>" +
                $"</div>" +
                $"<div class=\"pay-info-email pay-info-item\">" +
                $" <label class=\"pay-info-email__label\">Email*</label>" +
                $" <input type=\"text\" name=\"email\" value=\"{user.GetEmail()}\" id=\"email\" class=\"pay-info-email__inp\" required />" +
                $" <label id=\"errorEmail\" style=\"color: red;\"></label>" +
                $" </div>" +
                $"<div class=\"pay-info-more pay-info-item\">" +
                $" <label class=\"pay-info-more__label\">Thông tin bổ sung</label>" +
                $" <textarea name=\"more\" value=\"moreinfo\" id=\"more\" class=\"pay-info-more__inp\"  rows=\"5\" placeholder=\"Ghi chú thêm về thông tin cho đơn hàng\"></textarea>" +
                $"</div>";
            payInfo.InnerHtml =  str;
            
        }
        public void bindCartList()
        {
            List<CartProduct> list = (List<CartProduct>)Session["cartList"];
            string str = "<p class=\"pay-detail-product__item\"><span>Sản phẩm</span><span>Tạm tính</span></p>" +
                "<hr />";
            float totalOrder = 0;
            foreach(CartProduct x in list)
            {
                str += $"<p class=\"pay-detail-product__item\"><span>{x.Product.Name} x {x.Quantity}</span><span>{(x.Product.Price * x.Quantity).ToString("#,## đ")}</span></p>" +
                    $"<hr />";
                totalOrder += (float)x.Product.Price * x.Quantity;
            }
            string giamgia = Request.Cookies["giamgia"].Value;
            if (giamgia == "")
            {
                giamgia = "0%";
            }
            str += $"<p class=\"pay-detail-product__item\"><span>Phần trăm giảm giá</span><span>{giamgia}</span></p>";
            str += $"<hr />";
            payDetail.InnerHtml = str;
            giamgia = giamgia.Replace("%","");
            int percent = int.Parse(giamgia);
            totalOrder = totalOrder - (totalOrder * percent / 100);
            if(totalOrder != 0)
            total.InnerHtml = $"<span>Tổng</span><span>{totalOrder.ToString("#,## đ")}</span>";
            else
            {
                total.InnerHtml = $"<span>Tổng</span><span>0 đ</span>";
            }
        }
    }
}