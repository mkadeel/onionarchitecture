using AutoMapper;

namespace Onion.DependencyResolution
{
    public class AutomapperConfiguration
    {
        public static void IntializeAutomapper()
        {
            Mapper.Initialize(config =>
            {

            });
        }
    }
}