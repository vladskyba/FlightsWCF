using FlightsWCF.Context;
using FlightsWCF.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FlightsWCF
{
    public class UserService : IUserService
    {
        FlightsWCFContext _context = new FlightsWCFContext();

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
               _context.Users.Remove(user);
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
