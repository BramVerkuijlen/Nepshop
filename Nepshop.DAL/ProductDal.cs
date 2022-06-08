using Nepshop.Logic;
using Nepshop.Logic.Interface;
using Nepshop.Logic.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.DAL
{
    public class ProductDal : IProductDal, IProductMaintainerDal
    {

        readonly string ConnectionString = "Data Source=LAPTOP-VCK4O5UP;Initial Catalog=NepshopDB;Integrated Security=True";

        public void AddProduct(ProductDTO product)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand(

                    "INSERT INTO Product (Name,Description,Category,Picture,Price,Amount,Available) " +

                                $"ValueS (@Name,@Description,@Category,@Picture,@Price,@Amount,@Available)", conn);

                querry.Parameters.AddWithValue("@Name", product.Name);
                querry.Parameters.AddWithValue("@Description", product.Description);
                querry.Parameters.AddWithValue("@Category", product.Category);
                querry.Parameters.AddWithValue("@Picture", product.Picture);
                querry.Parameters.AddWithValue("@Price", product.Price);
                querry.Parameters.AddWithValue("@Amount", product.Amount);
                querry.Parameters.AddWithValue("@Available", product.Available);

                SqlDataReader reader = querry.ExecuteReader();

            }
        }


        public List<ProductDTO> GetAllProducts()
        {
            List<ProductDTO> products = new List<ProductDTO>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand querry = new SqlCommand("SELECT * FROM Product", conn))
                {
                    conn.Open();

                    SqlDataReader reader = querry.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductDTO product = new ProductDTO();

                        product.Id = reader.GetInt32(0);
                        product.Name = reader.GetString(1);
                        product.Description = reader.GetString(2);
                        product.Category = reader.GetString(3);
                        product.Picture = reader.GetString(4);
                        product.Price = reader.GetInt32(5);
                        product.Amount = reader.GetInt32(6);
                        product.Available = reader.GetBoolean(7);

                        products.Add(product);
                    }
                }
            }
            return products;
        }

        public void RemoveProduct(ProductDTO product)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("DELETE FROM Product WHERE (Id =@ProductId)", conn);

                querry.Parameters.AddWithValue("@ProductId", product.Id);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }

        public void UpdateProduct(ProductDTO product)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand(

                    "UPDATE Products SET (Name,Description,Category,Picture,Price,Amount,Available) " +

                                 $"VALUES (@Name,@Description,@Category,@Picture,@Price,@Amount,@Available)" +

                                 $"WHERE (Id =@ProductId)", conn);

                querry.Parameters.AddWithValue("@Name", product.Name);
                querry.Parameters.AddWithValue("@Description", product.Description);
                querry.Parameters.AddWithValue("@Category", product.Category);
                querry.Parameters.AddWithValue("@Picture", product.Picture);
                querry.Parameters.AddWithValue("@Price", product.Price);
                querry.Parameters.AddWithValue("@Amount", product.Amount);
                querry.Parameters.AddWithValue("@Available", product.Available);
                querry.Parameters.AddWithValue("@ProductId", product.Id);

                querry.ExecuteReader();
            }
        }

        public ProductDTO GetProductOnId(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("SELECT * FROM Product WHERE (Id =@ProductId", conn);

                querry.Parameters.AddWithValue("@ProductId", id);

                SqlDataReader reader = querry.ExecuteReader();

                if (reader.Read() == true)
                {
                    ProductDTO product = new ProductDTO();

                    product.Id = reader.GetInt32(0);
                    product.Name = reader.GetString(1);
                    product.Description = reader.GetString(2);
                    product.Category = reader.GetString(3);
                    product.Picture = reader.GetString(4);
                    product.Price = reader.GetInt32(5);
                    product.Amount = reader.GetInt32(6);
                    product.Available = reader.GetBoolean(7);

                    return product;
                }
                else
                {
                    ProductDTO product = new ProductDTO();

                    return product;
                }
            }
        }
    }
}
