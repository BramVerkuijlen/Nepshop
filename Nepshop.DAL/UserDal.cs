
using Nepshop.Logic.Interface;
using Nepshop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Nepshop.DAL
{
    public class UserDal : IUserDal, IUserMaintainerDal
    {

        readonly string ConnectionString = "Data Source=LAPTOP-VCK4O5UP;Initial Catalog=NepshopDB;Integrated Security=True";

        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void BuyCart()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();

            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using(SqlCommand querry = new SqlCommand("Select * from User", conn))
                {
                    conn.Open();

                    var reader = querry.ExecuteReader();

                    while (reader.Read())
                    {
                        UserDTO user = new UserDTO();

                        user.Id = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Firstname = reader.GetString(3);
                        user.Lastname = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.points = reader.GetInt32(6);

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public void RemoveUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
