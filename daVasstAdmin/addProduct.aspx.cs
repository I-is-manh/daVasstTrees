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
    public partial class addProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            productDao dao = new productDao();
            if (IsPostBack)
            {
                string linkimg = "../../Image/" + Request.Files["uploadfile"].FileName;
                string categoryID = Request.Form["category"];
                string nameproduct = Request.Form["name"];
                string price = Request.Form["price"];
                string discount = Request.Form["discount"];
                string quantity = Request.Form["quantity"];
                string desc = Request.Form["desc"];
                price = price.Replace(".", "");
                if (dao.GetProductByName(nameproduct) != null)
                {
                    Product product = dao.GetProductByName(nameproduct);
                    if(dao.updateQuantityProduct(product.ProductID, product.Quantity + int.Parse(quantity)))
                    {
                        overlayaddproduct.Attributes.Add("class", "overlayaddproduct-show");
                        Response.Redirect("ListProduct.aspx");
                    }
                }
                else
                {
                    if(dao.insertProduct(categoryID, nameproduct, price, discount, quantity, linkimg, desc))
                    {
                        overlayaddproduct.Attributes.Add("class", "overlayaddproduct-show");
                        Response.Redirect("ListProduct.aspx");
                    }
                }
            }
        }
    }
}