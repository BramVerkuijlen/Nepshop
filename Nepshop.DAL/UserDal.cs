
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
                using (SqlCommand querry = new SqlCommand(

                    "Insert Into User (Username, Password, Firstname, Lastname, Emial, Points)" +

                    $"VALUE ( {user.Username},{user.Password},{user.Firstname},{ user.Lastname },{ user.Email},{ user.Points})"

                    , conn))
                {
                    conn.Open();
                }
            }
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
                        user.Points = reader.GetInt32(6);

                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public UserDTO GetUserOnUsernameAndPassword(string username, string password)
        {
            UserDTO user = new UserDTO();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand querry = new SqlCommand(
                    "Select * from User" +
                    $"WHERE UserName = {username}" +
                    $"Password = {password}"
                    , conn))
                {
                    conn.Open();

                    var reader = querry.ExecuteReader();

                    while (reader.Read())
                    {
                        user.Id = reader.GetInt32(0);
                        user.Username = reader.GetString(1);
                        user.Password = reader.GetString(2);
                        user.Firstname = reader.GetString(3);
                        user.Lastname = reader.GetString(4);
                        user.Email = reader.GetString(5);
                        user.Points = reader.GetInt32(6);
                    }
                }
            }
            return user;
        }

        public void RemoveUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand querry = new SqlCommand("DELETE FROM User WHERE (Id = " + user.Id + ")", conn))
                {
                    conn.Open();
                }
            }
        }

        public void UpdateUser(UserDTO user)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand querry = new SqlCommand(

                    "Update User SET(Username, Password, Firstname, Lastname, Emial, Points)" +

                    $"VALUE ({user.Username},{user.Password},{user.Firstname},{user.Lastname},{user.Email},{user.Points})" +

                    $"WHERE Id = {user.Id})"
                    
                    , conn))
                {
                    conn.Open();
                }
            }
        }
    }
}
