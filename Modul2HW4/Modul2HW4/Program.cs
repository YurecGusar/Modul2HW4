using Microsoft.Extensions.DependencyInjection;
using Modul2HW4.Servises.Abstractions;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Providers;
using Modul2HW4.Servises;

namespace Modul2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .AddTransient<IAnimalService, AnimalService>()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddTransient<IConfigService, ConfigService>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
