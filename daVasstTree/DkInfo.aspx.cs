using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace daVasstTrees.daVasstTree
{
    public partial class DkInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> list = (List<string>)Application["dsTk"];
            if (IsPostBack)
            {
                string hoten = Request.Form["name"];
                string date = Request.Form["date"];
                string gt = Request.Form["gt"];
                string lop = Request.Form["lop"];
                string info = $" Họ và tên : {hoten} -- Ngày sinh : {date} -- Giới tính : {gt} -- Lớp : {lop}";
                list.Add(info);
                Application["dsTk"] = list;
            }
            if (Application["dsTk"] != null)
            {
                List<string> listArr = (List<string>)Application["dsTk"];
                string str = "";
                foreach(string x in listArr)
                {
                    str += $"<p>{x}</p>";
                }
                listtk.InnerHtml = str;
            }
        }
    }
}