using Nepshop.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepshop.Logic.Interface
{
    public interface IUserMaintainerDal
    {
        void AddUser(UserDTO userDTO);

        void RemoveUser(UserDTO userDTO);

        List<UserDTO> GetAllUsers();

        UserDTO GetUserOnUsernameAndPassword(string username, string password);
        
    }
}
