using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public interface ILoginService

    {
        Login login(Login userCreds);
        Login Register(Users user);
    }
}
