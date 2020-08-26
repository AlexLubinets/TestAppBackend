using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TestAppBackend.BLL.Models;
using TestAppBackend.DAL.Entities;

namespace TestAppBackend.BLL.Interfaces
{
    public interface IAuthService
    {
        Task<IdentityResult> CreateUser(RegisterModel model);
        Task<User> FindUserByName(LoginModel model);
        Task<User> FindUserById(string userId);
        Task<bool> UserExists(LoginModel model);
        Task<bool> IsLoginValid(LoginModel model);
        Task<string> CreateJwtToken(LoginModel model);
    }
}
