using Infra;
using Microsoft.Extensions.DependencyInjection;
using Echo.BusinessLogic;
using Echo.BusinessLogic.Interfaces;

namespace Echo
{
    internal static class BootUpConfig
    {
        internal static void SetUpServices()
        {
            var serviceColl = Dependencies.GetServiceCollection();
            serviceColl.AddSingleton<IFooService, FooService>();
        }
    }
}
