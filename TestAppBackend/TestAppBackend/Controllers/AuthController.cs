﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAppBackend.BLL.Constants;
using TestAppBackend.BLL.Interfaces;
using TestAppBackend.BLL.Models;

namespace TestAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Route("Register")]
        //POST: api/Auth/Register
        public async Task<IActionResult> RegisterUser(RegisterModel model)
        {
            try
            {
                var result = await authService.CreateUser(model);
                return Ok(result);
            }
            catch
            {
                return BadRequest(ErrorMessages.RegFail);
            }
        }

        [HttpPost]
        [Route("Login")]
        //POST: api/Auth/Login
        public async Task<IActionResult> LoginUser(LoginModel model)
        {
            try
            {
                var token = await authService.CreateJwtToken(model);
                return Ok(new { token });
            }
            catch
            {
                return Unauthorized(ErrorMessages.LoginFail);
            }
        }
    }
}