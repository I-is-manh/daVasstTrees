using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["taikhoandn"] != null)
                {
                    inptk.Value = Request.Cookies["taikhoandn"]["tk"];
                    inpmk.Value = Request.Cookies["taikhoandn"]["mk"];
                    inptk.Style.Add("border", "1px solid #00B214");
                    labeltk.Style.Add("top", "0");
                    labeltk.Style.Add("z-index", "1");
                    labeltk.Style.Add("background", "#FAFADF");
                }
            }
            userDao userdao = new userDao();
            if (IsPostBack)
            {
                string email = inptk.Value;
                string password = inpmk.Value;
                if (userdao.checkDn(email, password) == true)
                {
                    User user = userdao.getInfomation(email, password);
                    Session["checkdn"] = true;
                    HttpCookie mycookie = new HttpCookie("taikhoandn");
                    mycookie["tk"] = user.GetEmail();
                    mycookie["mk"] = user.GetCustomerPassword();
                    mycookie.Expires = DateTime.Now.AddDays(2);
                    Response.Cookies.Add(mycookie);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    labelError.Style.Add("display", "block");
                    inptk.Value = "";
                    inptk.Style.Add("border","1px solid red");
                    labeltk.Style.Add("color", "red");
                    inpmk.Style.Add("border", "1px solid red");
                    labelmk.Style.Add("color", "red");
                    return;
                }
            }
           
        }
    }
}