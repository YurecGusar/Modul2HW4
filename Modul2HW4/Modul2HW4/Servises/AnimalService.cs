using System;
using Modul2HW4.Servises.Abstractions;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4.Servises
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalProvider _animalProvider;
        public AnimalService(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void Convert()
        {
        }
    }
}
