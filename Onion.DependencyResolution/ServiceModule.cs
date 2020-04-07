using Ninject.Modules;
using Onion.Interfaces.Services;
using Onion.Services;

namespace Onion.DependencyResolution
{
    public class ServiceModule : NinjectModule
    {
        // Get config service
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
        }
    }
}