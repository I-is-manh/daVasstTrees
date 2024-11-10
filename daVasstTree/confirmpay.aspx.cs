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
    public partial class confirmpay : System.Web.UI.Page
    {
        orderDao orderdao = new orderDao();
        order od = null;
        orderDetailDao orderdetaildao = new orderDetailDao();
        productDao productdao = new productDao();
        userDao userdao = new userDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            double total = 0;
            string email = Request.Cookies["taikhoandn"]["tk"];
            string password = Request.Cookies["taikhoandn"]["mk"];
            User user = userdao.getInfomation(email,password);

            if (Request.Form["orderID"] == null)
            {
                od = orderdao.getOrderByID(orderdao.getOrderID(user.GetCustomerID()));
                List<orderDetail> orderdetail = orderdetaildao.getListOrderDetail(od.OrderID);
                dataBindProduct(orderdetail, ref total, od);
                dataBindInfo(od,total);
            }
            else
            {
                int id = int.Parse(Request.Form["orderID"]);
                od = orderdao.getOrderByID(id);
                List<orderDetail> orderdetail = orderdetaildao.getListOrderDetail(id);

                dataBindProduct(orderdetail, ref total, od);
                dataBindInfo(od, total);
            }
        }
        public void dataBindInfo(order od,double total)
        {
            string str = $"<p class=\"confirmpayDetail-info__title\">Cảm ơn bạn chúng tôi đã nhận được đơn hàng</p>" +
                $"<ul class=\"confirmpayDetail-info-listinfo\">" +
                $"<li class=\"confirmpayDetail-info-listinfo__item\">Mã đơn hàng : {od.OrderID}</li>" +
                $"<li class=\"confirmpayDetail-info-listinfo__item\">Ngày tạo : {od.CreateDate}</li>" +
                $"<li class=\"confirmpayDetail-info-listinfo__item\">Địa chỉ giao hàng : {od.Address}</li>" +
                $"<li class=\"confirmpayDetail-info-listinfo__item\">Phương thức thanh toán : {od.PTTT}</li>" +
                $" <li class=\"confirmpayDetail-info-listinfo__item\">Tổng cộng : {total.ToString("#,###")}</li>" +
                $"</ul>";
            confirmpayInfo.InnerHtml = str;
        }
        public void dataBindProduct(List<orderDetail> list,ref double total,order od)
        {
            string str = $"<p class=\"confirmpayDetail-product__item\"><span>Sản phẩm</span><span>Tổng</span></p>";
            foreach(orderDetail x in list)
            {
                Product product = productdao.getProductById(x.ProductID);
                total += product.Price * x.Quantity;
                str += $"<p class=\"confirmpayDetail-product__item\"><span>{product.Name} x {x.Quantity}</span><span>{(product.Price * x.Quantity).ToString("#,###")}</span></p>";
                    
            }
            str += $"<p class=\"confirmpayDetail-product__item\"><span>Tổng cộng</span><span>{total.ToString("#,### đ")}</span></p>";
            if(od.MoreInfo == "")
            {
                str += $"<p class=\"confirmpayDetail-product__item\"><span>Ghi chú</span><span>Không có ghi chú</span></p>";
            }
            else
            {
                str += $"<p class=\"confirmpayDetail-product__item\"><span>Ghi chú</span><span>{od.MoreInfo}</span></p>";
            }
            confirmpayProduct.InnerHtml = str;
        }
    }
}