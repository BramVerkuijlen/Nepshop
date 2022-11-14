
using Nepshop.Logic.Interface;
using Nepshop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Nepshop.Logic;

namespace Nepshop.DAL
{
    public class UserDal : IUserDal, IUserMaintainerDal
    {

        readonly string ConnectionString = "Data Source=LAPTOP-VCK4O5UP;Initial Catalog=NepshopDB;Integrated Security=True";

        public void AddUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                    
                SqlCommand querry = new SqlCommand("Insert Into Users (Username, Password, Firstname, Lastname, Email, Points)" +

                                                              "VALUES (@Username,@Password,@Firstname,@Lastname,@Email,@Points)", conn);

                querry.Parameters.AddWithValue("@Username", user.Username);
                querry.Parameters.AddWithValue("@Password", user.Password);
                querry.Parameters.AddWithValue("@Firstname", user.Firstname);
                querry.Parameters.AddWithValue("@Lastname", user.Lastname);
                querry.Parameters.AddWithValue("@Email", user.Email);
                querry.Parameters.AddWithValue("@Points", user.Points);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("Select * from Users", conn);

                SqlDataReader reader = querry.ExecuteReader();

                while (reader.Read())
                {
                    UserDTO user = new UserDTO();

                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Firstname = reader.GetString(3);
                    user.Lastname = reader.GetString(4);
                    user.Email = reader.GetString(5);
                    user.Points = reader.GetInt32(6);

                    users.Add(user);
                }
            }
            return users;
        }

        public UserDTO GetUserOnUsernameAndPassword(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", conn);

                querry.Parameters.AddWithValue("@Username", username);
                querry.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = querry.ExecuteReader();

                if (reader.Read() == true)
                {
                    UserDTO user = new UserDTO();

                    user.Id = reader.GetInt32(0);
                    user.Username = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Firstname = reader.GetString(3);
                    user.Lastname = reader.GetString(4);
                    user.Email = reader.GetString(5);
                    user.Points = reader.GetInt32(6);

                    return user;
                }
                else
                {
                    UserDTO user = new UserDTO();

                    return user;
                }
            }
        }

        public void RemoveUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("DELETE FROM Users WHERE (Id = @UserId )", conn);
                
                querry.Parameters.AddWithValue("UserId", userId);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }

        public void UpdateUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                SqlCommand querry = new SqlCommand("UPDATE Users SET Username = @Username, Password = @Password, Firstname = @Firstname, Lastname = @Lastname, Email = @Email, Points = @Points " +

                                                             "WHERE Id = @UserId", conn);

                querry.Parameters.AddWithValue("@Username", user.Username);
                querry.Parameters.AddWithValue("@Password", user.Password);
                querry.Parameters.AddWithValue("@Firstname", user.Firstname);
                querry.Parameters.AddWithValue("@Lastname", user.Lastname);
                querry.Parameters.AddWithValue("@Email", user.Email);
                querry.Parameters.AddWithValue("@Points", user.Points);
                querry.Parameters.AddWithValue("@UserId", user.Id);

                SqlDataReader reader = querry.ExecuteReader();
            }
        }
    }
}

