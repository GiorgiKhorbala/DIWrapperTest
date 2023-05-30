using System;

namespace DITesting.Wrappers
{
    public static class Injector
    {
        private static IServiceProvider _serviceProvider;

        public static void SetServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T GetService<T>() => (T)_serviceProvider.GetService(typeof(T));
    }
}

