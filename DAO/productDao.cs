using daVasstTrees.Model;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace daVasstTrees.DAO
{
    public class productDao
    {
        static string  str = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
        public static List<Product> getConnection(string sqlQuery)
        {
            List<Product> list = new List<Product>();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sqlQuery;
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
        public static Product getProduct(string sqlQuery)
        {
            Product product = new Product();
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sqlQuery;
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
                product = new Product(productID, categoryId, productName, price, discount, purchase,
                    quantity, linkImg, desc, status);
            }
            cmd.Dispose();
            con.Close();
            return product;
        }
        public Product getProductById(int productID)
        {
            Product product = new Product();
            string sqlQuery = $"select * from tblProduct where productID = {productID}";
            product = getProduct(sqlQuery);
            return product;
        }
        public List<Product> getProductByCategoryID(int categoryID,int productID)
        {
            List<Product> list = new List<Product>();
            string sqlQuery = $"select * from tblProduct where categoryID = {categoryID} and productId != {productID}";
            list = getConnection(sqlQuery);
            return list;
        }
        public List<Product> getProductPagination(int pageNow)
        {
            string sqlQuery = $"SELECT *\r\nFROM tblProduct \r\nORDER BY productId -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
            return getConnection(sqlQuery);
        }
        public List<Product> getListProduct(string category)
        {
            string sqlQuery = "";
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
            if (category == "")
            {
                sqlQuery = $"select * from tblProduct where status = '1'";
                return getConnection(sqlQuery);
            }
            else if (category == "bestseller")
            {
                sqlQuery = $"select  top 6 * from tblProduct  where status = '1' order by purchase desc";
                return getConnection(sqlQuery);
            }
            else
            {
                sqlQuery = $"select * from tblProduct where categoryID = {categoryID} and status = '1'";
                return getConnection(sqlQuery);
            }
        }
        public List<Product> getListProductpagination(string category, int pageNow,string sort)
        {
            int categoryID = 0;
            string sqlQuery = "";
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
            else if (category == "chaucay")
            {
                categoryID = 6;
            }
            else
            {
                categoryID = 7;
            }
            if (category == "")
            {
                //sqlQuery = $"select * from tblProduct  where status = '1' ORDER BY productId -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";

                if (sort == "caodenthap")
                {
                    sqlQuery = $"select * from tblProduct  where status = '1' ORDER BY price desc  OFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";

                }
                else if(sort == "thapdencao")
                {
                    sqlQuery = $"select * from tblProduct  where status = '1' ORDER BY price  -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
                }
                else
                {
                    sqlQuery = $"select * from tblProduct  where status = '1' ORDER BY productId  -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
                }
                return getConnection(sqlQuery);
            }
            else if (category == "bestseller")
            {
                sqlQuery = $"select  top 6 * from tblProduct  where status = '1' order by purchase desc";
                return getConnection(sqlQuery);
            }
            else
            {
                //sqlQuery = $"select * from tblProduct where status='1' and categoryID = {categoryID} ORDER BY productId -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
                if (sort == "caodenthap")
                {
                    sqlQuery = $"select * from tblProduct where status='1' and categoryID = {categoryID} ORDER BY price desc -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
                }
                else if(sort == "thapdencao")
                {
                    sqlQuery = $"select * from tblProduct where status='1' and categoryID = {categoryID} ORDER BY price -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";
                }
                else
                {
                    sqlQuery = $"select * from tblProduct where status='1' and categoryID = {categoryID} ORDER BY productId -- Cột để sắp xếp\r\nOFFSET {pageNow * 8 - 8} ROWS -- Bỏ qua số hàng này\r\nFETCH NEXT 8 ROWS ONLY;";

                }
                return getConnection(sqlQuery);
            }
        }
        public List<Product> getSearchProductPagination( string key , int pageNow,string sort)
        {
            string sqlQuery = "";
            if(sort == "caodenthap")
            {
                sqlQuery = $"SELECT * " +
                $"FROM tblProduct " +
                $"where productName like N'%{key}%' " +
                $"ORDER BY price desc " +
                $"OFFSET {pageNow * 8 - 8} ROWS " +
                $"FETCH NEXT 8 ROWS ONLY;";
            }
            else if(sort == "thapdencao")
            {
                sqlQuery = $"SELECT * " +
                $"FROM tblProduct " +
                $"where productName like N'%{key}%' " +
                $"ORDER BY price " +
                $"OFFSET {pageNow * 8 - 8} ROWS " +
                $"FETCH NEXT 8 ROWS ONLY;";
            }
            else
            {
                sqlQuery = $"SELECT * " +
                $"FROM tblProduct " +
                $"where productName like N'%{key}%' " +
                $"ORDER BY productId " +
                $"OFFSET {pageNow * 8 - 8} ROWS " +
                $"FETCH NEXT 8 ROWS ONLY;";
            }
            return getConnection(sqlQuery);
        }
        public List<Product> getSearchProductAll(string key)
        {
            string sqlQuery = $"SELECT * " +
                $"FROM tblProduct " +
                $"where productName like N'%{key}%' ";
            return getConnection(sqlQuery);
        }
        public bool updateProduct(int productID, string productname,string price,string discount,string quantity,string linkimg,string desc)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"update tblProduct " +
                $"set productName = N'{productname}',price='{price}',discount_percent='{discount}',quantity='{quantity}',image='{linkimg}',description=N'{desc}'" +
                $"where productId = {productID}";
            conn.Open();
            if(cmd.ExecuteNonQuery() != -1)
            {
                cmd.Dispose();
                conn.Close();
                return true;
            }
            else
            {
                cmd.Dispose();
                conn.Close();
                return false;

            }
        }
        public void removeProduct(int id)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"update tblProduct set status='0' where productId={id}";
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
        public Product GetProductByName(string name)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select * from tblProduct where productName = N'{name}' and status='1'";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Product product = null;
            if (dr.Read())
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
                product = new Product(productID, categoryId, productName, price, discount, purchase,
                    quantity, linkImg, desc, status);
            }
            return product;
        }
        public bool updateQuantityProduct(int id,int quantity)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"update tblProduct set quantity = {quantity} where productId='{id}'";
            conn.Open();
            if(cmd.ExecuteNonQuery() == -1)
            {
                cmd.Dispose();
                conn.Close();
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool insertProduct(string categoryId, string productname, string price, string discount, string quantity, string linkimg, string desc)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"insert into tblProduct " +
                $"values('{categoryId}',N'{productname}','{price}','{discount}','0','{quantity}','{linkimg}',N'{desc}','1')";
            conn.Open();
            if(cmd.ExecuteNonQuery() == -1)
            {
                cmd.Dispose();
                conn.Close();
                return false;
            }
            else
            {
                cmd.Dispose();
                conn.Close();
                return true;
            }
        }
    }
}