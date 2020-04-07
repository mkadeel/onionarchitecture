using Ninject.Modules;
using Onion.Data;
using Onion.Interfaces;
using Onion.Repositories;

namespace Onion.DependencyResolution
{
    public class RepositoryModule : NinjectModule
    {
        // Get config service
        public override void Load()
        {
            Bind<IApplicationDBContext>().To<ApplicationDBContext>().WithConstructorArgument("Name", "ApplicationConnectionString");
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
