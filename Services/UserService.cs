using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class UserService : IUserService
    {
        private readonly ordermanagement081242Context _context;

        public UserService(ordermanagement081242Context context)
        {
            _context = context;
        }


        public Users AddUser(Users user)
        {

            var u = _context.Users.Add(user);
            _context.SaveChanges();
            if (u != null)
                return user;
            else return null;

        }

        public List<Users> GetAllUsers()
        {
            if (_context.Users.ToList().Count() > 0)
                return _context.Users.ToList();
            return null;
            {
            }
        }
    }
}
