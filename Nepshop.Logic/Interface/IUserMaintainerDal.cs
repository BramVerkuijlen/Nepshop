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
        void AddUser();

        void RemoveUser();

        List<UserDTO> GetAllUsers();
    }
}
