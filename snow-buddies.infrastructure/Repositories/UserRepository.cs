using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using snow_buddies.application;
using snow_buddies.domain.Entities;
using snow_buddies.infrastructure.data;
using snow_buddies.application.IRepositories;

namespace snow_buddies.infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SnowBuddiesDbContext _context;

        public UserRepository(SnowBuddiesDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}