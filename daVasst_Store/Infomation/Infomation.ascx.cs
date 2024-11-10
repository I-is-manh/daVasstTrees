using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.Infomation
{
    public partial class Infomation : System.Web.UI.UserControl
    {
        userDao dao = new userDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["taikhoandn"]["tk"] == null && Request.Cookies["taikhoandn"]["mk"] == null)
            {
                return;
            }
            string email = Request.Cookies["taikhoandn"]["tk"];
            string password = Request.Cookies["taikhoandn"]["mk"];
            User user = dao.getInfomation(email, password);
            string str = "";
            str += $"<div class=\"infomation-detail-updateimg\">" +
                $"<div class=\"infomation-detail-updateimg__img\">" +
                $"<img src={user.GetAvatar()} alt=\"Alternate Text\" / id=\"imgavt\">  " +
                $"<div class=\"infomation-detail-updateimg__camera\">" +
                $"<img src=\"../../Image/camera.jpg\" alt=\"Alternate Text\"  />" +
                $"<input type=\"file\" name=\"uploadfile\" value=\"{user.GetAvatar()}\"/ id=\"inputfile\"> " +
                $"</div>" +
                $"</div>" +
                $"<p>{user.GetFullName()}</p>" +
                $" </div>" +
                $"<div class=\"infomation-detail__fullname infomation-detail__item\">" +
                $"<label>Họ và tên : </label>" +
                $" <input type=\"text\" name=\"fullname\" value=\"{user.GetFullName()}\" id=\"fullname\"/>" +
                $"<label id=\"errorFullName\" style=\"color:red\"></label>" +
                $"</div>" +
                $"<div class=\"infomation-detail__email infomation-detail__item\">" +
                $" <label>Email : </label>" +
                $"<input type=\"email\" name=\"email\" value=\"{user.GetEmail()}\" id=\"email\"/>" +
                $"<label id=\"errorEmail\"></label>" +
                $" </div>" +
                $" <div class=\"infomation-detail__address infomation-detail__item\">" +
                $"<label>Địa chỉ giao hàng : </label>" +
                $" <input type=\"text\" name=\"address\" value=\"{user.GetAddress()}\" id=\"address\"/>" +
                $"<label id=\"errorAddress\" style=\"color:red\"></label>" +
                $" </div>" +
                $" <div class=\"infomation-detail__numberphone infomation-detail__item\">" +
                $"<label>Số điện thoại : </label>" +
                $"<input type=\"text\" name=\"numberphone\" value=\"{user.GetNumberphone()}\" id=\"numberphone\" />" +
                $"<label id=\"errorNumberPhone\" style=\"color:red\"></label>" +
                $"</div>" +
                $"<div class=\"infomation-detail-btn\">" +
                $"<button type=\"submit\" class=\"infomation-detail-btn__update btnAll\">Cập nhật</button>" +
                $"<button type=\"button\" class=\"infomation-detail-btn__signout btnAll\" value=\"signout\" name=\"signout\"><a href=\"signout.aspx\">Đăng xuất</a></button>" +
                $"</div>";
            infomation.InnerHtml = str;
            

        }
        
    }

}