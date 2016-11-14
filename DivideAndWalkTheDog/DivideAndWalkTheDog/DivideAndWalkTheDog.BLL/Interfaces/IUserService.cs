using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DivideAndWalkTheDog.BLL.DTO;

namespace DivideAndWalkTheDog.BLL.Interfaces
{
    public interface IUserService
    {
        UserDTO GetUser(int userId);
        IEnumerable<UserDTO> GetAllUsers();
        void CreateUser(UserDTO user);
        void EditUser(UserDTO user);
        UserDTO GetUserByApplicationId(string applicationId);
    }
}
