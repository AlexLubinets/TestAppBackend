using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestAppBackend.BLL.Interfaces;
using TestAppBackend.DAL.Entities;

namespace TestAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        [Route("List")]
        //Get: api/Users/List
        public List<User> GetUsers()
        {
            return usersService.GetAllUsers();
        }
    }
}