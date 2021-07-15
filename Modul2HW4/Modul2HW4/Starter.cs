using System;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4
{
    public class Starter
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly IHabitatService _habitat;
        public Starter(IAnimalProvider animalProvider, IHabitatService habitatService)
        {
            _animalProvider = animalProvider;
            _habitat = habitatService;
        }

        public void Run()
        {
            _habitat.Add("Юго-западный африканский лев");
            _habitat.Add("Шакал обыкновенный");
            Console.WriteLine(_habitat.AnimalsInHabitat.FindByName("Шакал обыкновенный") is Canine);
        }
    }
}
