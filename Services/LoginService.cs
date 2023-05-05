using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserService _userService;
    private readonly ITokenGeneration _tokenGeneration;


    public LoginService(IUserService userService, ITokenGeneration tokenGeneration)
    {
        _userService = userService;
        _tokenGeneration = tokenGeneration;
    }

    public Login login(Login userCreds)
    {
        var user = _userService.GetAllUsers().FirstOrDefault(u => u.Email == userCreds.Email);

        if (user != null)
        {

            if (user.Password != userCreds.Password)
            {
                return null;
            }
            userCreds.Password = user.Password;
            userCreds.Token = _tokenGeneration.GenerateToken(userCreds);
            return userCreds;
        }
        return null;
    }



    public Login Register(Users user)
    {
        Users userDetails = null;
        var users = _userService.GetAllUsers().FirstOrDefault(u => u.Email == user.Email);
        if (users == null)
        {
            userDetails = _userService.AddUser(user);
        }


        if (userDetails != null)
            return new Login
            {
                Email = user.Email,
                Token = _tokenGeneration.GenerateToken(new Login { Email = user.Email })
            };
        return null;

    }
        }
    }