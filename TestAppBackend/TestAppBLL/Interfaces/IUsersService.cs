using System.Collections.Generic;
using TestAppBackend.DAL.Entities;

namespace TestAppBackend.BLL.Interfaces
{
    public interface IUsersService
    {
        List<User> GetAllUsers();
    }
}