using Ninject.Modules;
using Onion.Data;
using Onion.Domain.Models;
using Onion.Interfaces;
using Onion.Repository.Repositories;

namespace Onion.DependencyResolution
{
    public class RepositoryModule : NinjectModule
    {
        // Get config service
        public override void Load()
        {
            Bind<IApplicationDBContext>().To<ApplicationDBContext>().WithConstructorArgument("Name", "ApplicationConnectionString");
            Bind<IBaseRepository<User>>().To<BaseRepository<User>>();
        }
    }
}
