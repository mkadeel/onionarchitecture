using System.Collections.Generic;
using System.Linq;
using Onion.Domain.Models;
using Onion.Interfaces;
using Onion.Interfaces.Services;

namespace Onion.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetQueryable().ToList();
        }
        


    }
}


