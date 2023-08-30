using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using snow_buddies.domain.Entities;

namespace snow_buddies.application.IServices
{
    public interface IUserService
    {
        public List<User> GetAllUsers();

        public User CreateUser(User user );

        public User GetUserById(int id);
    }
}