
using Onion.Domain.Models;
using Onion.Interfaces;
using Onion.Repository.Repositories;

namespace Onion.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IApplicationDBContext context) : base(context)
        {

        }
      
    }
}
