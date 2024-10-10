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
    public partial class signup : System.Web.UI.Page
    {
        userDao dao = new userDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string email = Request.Form["taikhoan"];
                string password = Request.Form["password"];
                if (dao.checkEmailExist(email) != 0)
                {
                    hidden.Value = "datontai";
                }
                else
                {
                    if (dao.signUp(email, password) == true)
                    {
                        User user = dao.getInfomation(email, password);
                        Session["checkdn"] = true;
                        HttpCookie mycookie = new HttpCookie("taikhoandn");
                        mycookie["tk"] = user.GetEmail();
                        mycookie["mk"] = user.GetCustomerPassword();
                        mycookie.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Add(mycookie);
                        Response.Redirect("Home.aspx");
                    }
                }
            }
        }
    }
}