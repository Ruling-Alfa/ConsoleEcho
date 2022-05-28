using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class Dependencies
    {
        private static readonly IServiceCollection _serviceProvider = new ServiceCollection();
        private static IServiceProvider? _collection;

        public static IServiceCollection GetServiceCollection()
        {
            return _serviceProvider;
        }

        private static void BuildServices()
        {
            _collection = _serviceProvider.BuildServiceProvider();
        }

        public static T? GetService<T>()
        {
            if (_collection == null)
            {
                BuildServices();
            }
            if (_collection == null)
            {
                throw new NullReferenceException("Service Collection is not Configured properly");
            }
            else
            {
                return _collection.GetService<T>();
            }
        }

    }
}