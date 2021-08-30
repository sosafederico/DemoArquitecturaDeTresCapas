using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDataAccess
    {
        public void AddProduct(Product product)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["StoreDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("INSERT INTO dbo.Products(Name, Description, UnitPrice, UnitsInStock, Discontinued, CategoryId)" +
                                  "VALUES ('{0}', '{1}', {2}, {3}, {4}, {5})", product.Name, product.Description, product.UnitPrice,
                                  product.UnitsInStock, product.Discontinued == true? 1 : 0, product.CategoryId);

            command.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
