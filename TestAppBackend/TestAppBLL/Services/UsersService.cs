using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using TestAppBackend.BLL.Interfaces;
using TestAppBackend.DAL.Entities;

namespace TestAppBackend.BLL.Services
{
    public class UsersService : IUsersService
    {
        private readonly UserManager<User> userManager;

        public UsersService(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public List<User> GetAllUsers()
        {
            return userManager.Users.OrderBy(r=>r.FullName).ToList();
        }
    }
}