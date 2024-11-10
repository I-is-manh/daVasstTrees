using daVasstTrees.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstAdmin
{
    public partial class removeProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            productDao dao = new productDao();
            if (Request.QueryString["id"] != null)
            {
                dao.removeProduct(int.Parse(Request.QueryString["id"]));
                Response.Redirect("ListProduct.aspx");
            }
        }
    }
}