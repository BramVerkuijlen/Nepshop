using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nepshop.DAL;
using Nepshop.Logic;
using Nepshop.Logic.DTO;
using Nepshop.Logic.Interface;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace UnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AddUser_AddExistingUser_ReturnsFalse()
        {
            IUserMaintainerDal userMaintainerDal = new FakeUserDB();
            UserMaintainer userMaintainer = new UserMaintainer(userMaintainerDal);

            UserDTO userDTO = new UserDTO();

            userDTO.Username = "Piet";
            userDTO.Password = "1234";
            userDTO.Firstname = "Piet";
            userDTO.Lastname = "Peters";
            userDTO.Email = "Piet@piet.nl";
            userDTO.Points = 11111;

            bool Result = userMaintainer.AddUser(userDTO.Username, userDTO.Password, userDTO.Firstname, userDTO.Lastname, userDTO.Email, userDTO.Points);

            Assert.IsFalse(Result);
            int userCount = userMaintainer.GetAllUsers().Count;
            Assert.AreEqual(3, userCount);
        }

        [TestMethod]
        public void AddUser_AddNewUser_ReturnsTrue()
        {
            IUserMaintainerDal userMaintainerDal = new FakeUserDB();
            UserMaintainer userMaintainer = new UserMaintainer(userMaintainerDal);

            UserDTO userDTO = new UserDTO();

            userDTO.Username = "Menno";
            userDTO.Password = "289564";
            userDTO.Firstname = "Menno";
            userDTO.Lastname = "Paards";
            userDTO.Email = "mennoPaards@paardenraces.com";
            userDTO.Points = 3919;

            bool Result = userMaintainer.AddUser(userDTO.Username, userDTO.Password, userDTO.Firstname, userDTO.Lastname, userDTO.Email, userDTO.Points);

            Assert.IsTrue(Result);
            int userCount = userMaintainer.GetAllUsers().Count;
            Assert.AreEqual(4, userCount);
        }

        [TestMethod]

        public void GetAllUsers_GetAllUsers_ReturnsUsers()
        {
            IUserMaintainerDal userMaintainerDal = new FakeUserDB();
            UserMaintainer userMaintainer = new UserMaintainer(userMaintainerDal);

            List<UserDTO> userDTOs = new List<UserDTO>();

            userDTOs = userMaintainer.GetAllUsers();

            Assert.AreEqual(3, userDTOs.Count);
            Assert.IsNotNull(userDTOs);
        }

        [TestMethod]
        public void RemoveUsers_RemovePiet_ReturnsUsers()
        {
            IUserMaintainerDal userMaintainerDal = new FakeUserDB();
            UserMaintainer userMaintainer = new UserMaintainer(userMaintainerDal);

            UserDTO userDTO = new UserDTO();

            userMaintainer.RemoveUser(1);

            int userCount = userMaintainer.GetAllUsers().Count;
            Assert.AreEqual(2, userCount);
        }


    }
}
