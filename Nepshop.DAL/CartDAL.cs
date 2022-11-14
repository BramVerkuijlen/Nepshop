using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;

namespace Nepshop.DAL
{
    public class CartDAL : ICartDAL
    {

        readonly string ConnectionString = "Data Source=LAPTOP-VCK4O5UP;Initial Catalog=NepshopDB;Integrated Security=True";

        public void AddProductToCart(string userId, string productId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                conn.Open();

                SqlCommand querry = new SqlCommand(

                    "INSERT INTO CartJoin (UserId, ProductId) " +

                                  $"VALUES (@UserId, @ProductId)", conn);

                querry.Parameters.AddWithValue("@UserId", userId);
                querry.Parameters.AddWithValue("@ProductId", productId);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }

        public List<ProductDTO> GetProductsInCart(string userId, string productId)
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand(

                    "SELECT * FROM CartJoin" +
                    "INNER JOIN Product" + 
                    "ON CartJoin.ProductId = Product.ProductId" +
                    "WHERE (UserId = @UserId)", conn);

                querry.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = querry.ExecuteReader();

                while (reader.Read())
                {
                    ProductDTO product = new ProductDTO();

                    product.Id = reader.GetInt32(1);
                    product.Name = reader.GetString(2);
                    product.Description = reader.GetString(3);
                    product.Category = reader.GetString(4);
                    product.Picture = reader.GetString(5);
                    product.Price = reader.GetInt32(6);
                    product.Amount = reader.GetInt32(7);
                    product.Available = reader.GetBoolean(8);

                    products.Add(product);
                }
            }
            return products;
        }

        public void RemoveProductFromCart(string userId, string productId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("DELETE FROM CartJoin WHERE (UserId = @UserId, ProductId = @ProductId)", conn);

                querry.Parameters.AddWithValue("@UserId", userId);
                querry.Parameters.AddWithValue("@ProductId", productId);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }

    }
}
