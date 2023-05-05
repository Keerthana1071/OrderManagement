using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public AuthController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(Login login)
        {
            var users = _loginService.login(login);
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("register")]
        public ActionResult Register(Users user)
        {
            var result = _loginService.Register(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }


    }
}