using daVasstTrees.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstTree
{
    public partial class changePassword : System.Web.UI.Page
    {
        userDao dao = new userDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (IsPostBack)
            {
                string email = inptk.Value;
                string password = inpmk.Value;
                if(dao.changePassWord(email,password) == true)
                {
                    Response.Redirect("login.aspx");
                }
            }
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
            else
            {
                inptk.Value = Request.Cookies["taikhoandn"]["tk"];
            }
        }
    }
}