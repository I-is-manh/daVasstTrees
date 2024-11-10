using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["checkdnAdmin"] == null)
            {
                Response.Redirect("login4Admin.aspx");
            }
            else
            {
                Response.Redirect("ListProduct.aspx");
            }
        }
    }
}