using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.header
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["checkdn"] == null)
            {
                tkButton.Style.Add("display", "none");
                dnButton.Style.Add("display", "block");
                dkButton.Style.Add("display", "block");
                
            }
            else
            {
                tkButton.Style.Add("display", "block");
                dnButton.Style.Add("display","none");
                dkButton.Style.Add("display", "none");
            }
        }
    }
}