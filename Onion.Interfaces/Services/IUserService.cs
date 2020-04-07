using System.Collections.Generic;
using Onion.Domain.Models;

namespace Onion.Interfaces.Services
{
    public interface IUserService
    {

        List<User> GetAllUsers();

    }
}