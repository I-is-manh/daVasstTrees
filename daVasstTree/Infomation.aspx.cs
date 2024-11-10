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
    public partial class Infomation : System.Web.UI.Page
    {
        userDao dao = new userDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                overlay.Style.Add("display", "block");
                string email = Request.Cookies["taikhoandn"]["tk"];
                string password = Request.Cookies["taikhoandn"]["mk"];
                User user = dao.getInfomation(email, password);
                string linkimg = user.GetAvatar();
                if (Request.Files["uploadfile"].FileName != null) {
                    linkimg = "../../Image/" + Request.Files["uploadfile"].FileName;
                }
                string fullname = Request.Form["fullname"];
                string emailSubmit = Request.Form["email"];
                string address = Request.Form["address"];
                string numberphone = Request.Form["numberphone"];
                dao.updateUser(user.GetCustomerID(), fullname, emailSubmit,address,numberphone, linkimg);
            }
        }
    }
}