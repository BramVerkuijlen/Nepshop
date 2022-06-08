using Moq;
using Nepshop.Logic.DTO;
using Nepshop.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTests
{
    public class FakeUserDB : IUserMaintainerDal
    {
        public FakeUserDB()
        {
            // create some mock Users to play with
            List<UserDTO> users = new List<UserDTO>
                {
                    new UserDTO { Username = "Piet", Password = "1234",Firstname = "Piet", Lastname = "peters", Email = "piet@gmail.com", Points = 100 },
                    new UserDTO { Username = "Joris", Password = "4567",Firstname = "Joris", Lastname = "Berg", Email = "Joris@gmail.com", Points = 600 },
                    new UserDTO { Username = "Peter", Password = "7890",Firstname = "Peter", Lastname = "peters", Email = "Peter@gmail.com", Points = 1200 }
                };

            // Mock the User Repository using Moq
            Mock<IUserMaintainerDal> mockUserRepository = new Mock<IUserMaintainerDal>();

            // Return all the Users
            mockUserRepository.Setup(mr => mr.GetAllUsers()).Returns(users);

            // return a User by Username & Password
            mockUserRepository.Setup(mr => mr.GetUserOnUsernameAndPassword(
                It.IsAny<string>(), It.IsAny<string>())).Returns((string s, string p) =>
                {
                    if ((users.Where(x => x.Username == s && x.Password == p).ToList().Count > 0))
                    {
                        return users.Where(x => x.Username == s && x.Password == p).Single();
                    }

                    else
                    {
                        return new UserDTO();
                    }

                });

            mockUserRepository.Setup(mr => mr.AddUser(It.IsAny<UserDTO>())).Callback<UserDTO>(
            (UserDTO target) =>
                {
                    target.Id = users.Count() + 1;
                    users.Add(target);
                });

            mockUserRepository.Setup(mr => mr.RemoveUser(It.IsAny<int>())).Callback(
                (int i) =>
                {

                    int j = i - 1;
                    users.RemoveAt(j);

                });


            // Complete the setup of our Mock Product Repository
            this.mockUserRepository = mockUserRepository.Object;
        }

        public readonly IUserMaintainerDal mockUserRepository;

        public void AddUser(UserDTO userDTO)
        {
            mockUserRepository.AddUser(userDTO);
        }

        public List<UserDTO> GetAllUsers()
        {
            return mockUserRepository.GetAllUsers();
        }

        public UserDTO GetUserOnUsernameAndPassword(string username, string password)
        {
            return mockUserRepository.GetUserOnUsernameAndPassword(username, password);
        }

        public void RemoveUser(int userId)
        {
            mockUserRepository.RemoveUser(userId);
        }
    }
}
