using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class daVasstAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["infoAdmin"] != null)
            {
                Admin admin = (Admin)Session["infoAdmin"];
                nameAdmin.InnerHtml = "Hi! "+admin.Fullname;
            }
            
        }
    }
}