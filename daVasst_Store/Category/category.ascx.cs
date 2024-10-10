using daVasstTrees.DAO;
using daVasstTrees.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasst_Store.Category
{
    public partial class category : System.Web.UI.UserControl
    {
        categoryDao dao = new categoryDao();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            if (Request.QueryString["id"] != null)
            {
                id = int.Parse(Request.QueryString["id"]);
            }
            List<Categoryy> list = dao.getListCategory();
            string str = "";
            foreach(Categoryy x in list)
            {
                if(x.Id == id)
                {
                    str += $"<li class=\"category-surro-list__item active\"><a href=\"productList.aspx?id={x.Id}\" class=\"active-a\">{x.Name}</a>\r\n " +
                        $"</li>";
                }
                else
                {
                    str += $"<li class=\"category-surro-list__item\"><a href=\"productList.aspx?id={x.Id}\">{x.Name}</a>\r\n " +
                        $"</li>";
                }

            }
            listCategory.InnerHtml = str;
        }
    }
}