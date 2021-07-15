using System;
using Modul2HW4.Servises.Abstractions;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4.Servises
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalProvider _animalProvider;
        private readonly IConfigService _config;
        private Animal[] _animals;
        public AnimalService(IAnimalProvider animalProvider, IConfigService config)
        {
            _animalProvider = animalProvider;
            _animals = _animalProvider.GetAnimals();
            _config = config;
        }

        public void Convert()
        {
        }
    }
}
