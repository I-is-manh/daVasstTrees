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
            string str = "<li class=\"category-surro-list__item\"><a href=\"productList.aspx?page=1\">Tất cả sản phẩm</a>\r\n            </li>";
            foreach(Categoryy x in list)
            {
                if(x.Id == id)
                {
                    str += $"<li class=\"category-surro-list__item active\"><a href=\"productList.aspx?id={x.Id}&page=1\" class=\"active-a\">{x.Name}</a>\r\n " +
                        $"</li>";
                }
                else
                {
                    str += $"<li class=\"category-surro-list__item\"><a href=\"productList.aspx?id={x.Id}&page=1\">{x.Name}</a>\r\n " +
                        $"</li>";
                }

            }
            listCategory.InnerHtml = str;
            if (Request.Form["gia"] != null)
            {
                if (Request.QueryString["gia"] == "thapdencao")
                {
                    thapdencao.Checked = true;
                }
                else
                {
                    caodenthap.Checked = true;
                }
            }
            
        }
    }
}