using System;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4
{
    public class Starter
    {
        private readonly IAnimalService _animalServ;
        private readonly IAnimalProvider _animalProvider;
        private readonly IHabitatService _habitat;
        public Starter(IAnimalProvider animalProvider, IHabitatService habitatService, IAnimalService animalService)
        {
            _animalServ = animalService;
            _animalProvider = animalProvider;
            _habitat = habitatService;
        }

        public void Run()
        {
            _habitat.Add("Юго-западный африканский лев");
            _habitat.Add("Шакал обыкновенный");
            _habitat.Add("Дорпер");
            Console.WriteLine(_habitat.AnimalsInHabitat.FindByName("Шакал обыкновенный") as Canine);
            Array.Sort(_habitat.AnimalsInHabitat, new AnimalSortExtension());
            foreach (var item in _habitat.AnimalsInHabitat)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Name} {item.Speed} {item.SpeedUnits}");
                }
            }
        }
    }
}
