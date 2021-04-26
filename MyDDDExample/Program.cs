using Microsoft.Extensions.DependencyInjection;
using System;

namespace MyDDDExample
{
    class Program
    {
        private static ServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            Startup();
        }

        private static void Startup()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IUserRepository>();
            // serviceCollection.AddSingleton<IUserRepository, InMemoryUserRepository>();
            serviceCollection.AddTransient<UserService>();
            serviceCollection.AddTransient<UserApplicationService>();
            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
