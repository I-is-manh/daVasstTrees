using daVasstTrees.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace daVasstTrees.DAO
{
    public class productDao
    {
        string str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public List<Product> getListProduct(string category)
        {
            int categoryID = 0;
            if (category == "de-ban")
            {
                categoryID = 1;
            }
            else if (category == "thuy-sinh")
            {
                categoryID = 2;
            }
            else if (category == "senda&xuongrong")
            {
                categoryID = 3;
            }
            else if (category == "caychautreo")
            {
                categoryID = 4;
            }
            else if (category == "cayantrai")
            {
                categoryID = 5;
            }
            else if(category == "chaucay"){
                categoryID = 6;
            }
            else
            {
                categoryID = 7;
            }
            List<Product> list = new List<Product>();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            if (category == "")
            {
                cmd.CommandText = $"select * from tblProduct";
            }
            else if (category == "bestseller")
            {
                cmd.CommandText = $"select  top 6 * from tblProduct order by purchase desc";
            }
            else
            {
                cmd.CommandText = $"select * from tblProduct where categoryID = {categoryID}";
            }
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int productID = dr.GetInt32(0);
                int categoryId = dr.GetInt32(1);
                string productName = dr.GetString(2);
                float price = float.Parse(dr["price"].ToString());
                float discount = float.Parse(dr["discount_percent"].ToString());
                int purchase = dr.GetInt32(5);
                int quantity = dr.GetInt32(6);
                string linkImg = dr.GetString(7);
                string desc = dr.GetString(8);
                bool status = dr.GetBoolean(9);
                Product product = new Product(productID, categoryId, productName, price, discount, purchase,
                    quantity, linkImg, desc, status);
                list.Add(product);
            }
            cmd.Dispose();
            con.Close();
            return list;
        }
    }
}