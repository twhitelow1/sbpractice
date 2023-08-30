using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using snow_buddies.application.IServices;
using snow_buddies.application.IRepositories;
using snow_buddies.domain.Entities;

namespace snow_buddies.application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User CreateUser(User user )
        {
            return _userRepository.CreateUser(user);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}