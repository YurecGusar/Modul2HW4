using System.Collections;
using Microsoft.Extensions.DependencyInjection;
using Modul2HW4.Extension;
using Modul2HW4.Providers;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .AddSingleton<IAnimalService, AnimalService>()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddSingleton<IHabitatService, HabitatService>()
                .AddTransient<IConfigService, ConfigService>()
                .BuildServiceProvider();
            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
