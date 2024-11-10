using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class login4Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            daoAdmin dao = new daoAdmin();
            if (IsPostBack)
            {
                string email = inptk.Value;
                string password = inpmk.Value;
                if (dao.getAdmin(email, password) != null)
                {
                    Admin admin = dao.getAdmin(email, password);
                    Session["checkdnAdmin"] = true;
                    Session["infoAdmin"] = admin;
                    Response.Redirect("ListProduct.aspx");
                }
                else
                {
                    labelError.Style.Add("display", "block");
                    inptk.Value = "";
                    inptk.Style.Add("border", "1px solid red");
                    labeltk.Style.Add("color", "red");
                    inpmk.Style.Add("border", "1px solid red");
                    labelmk.Style.Add("color", "red");
                    return;
                }
            }
        }
    }
}