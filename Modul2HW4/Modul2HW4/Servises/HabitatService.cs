using Modul2HW4.Models;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4.Servises
{
    public class HabitatService
    {
        private readonly IAnimalProvider _animalProvider;
        private Animal[] _habitat;

        public HabitatService(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void Add(string name)
        {
            _habitat = _animalProvider.AllAnimals;
        }
    }
}
