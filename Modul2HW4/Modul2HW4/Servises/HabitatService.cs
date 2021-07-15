using Modul2HW4.Models;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4.Servises
{
    public class HabitatService : IHabitatService
    {
        private readonly IAnimalProvider _animalProvider;
        private Animal[] _habitat;
        private int _counter = 0;

        public HabitatService(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
            _habitat = new Animal[_animalProvider.AllAnimals.Length]; // добавить в конфиг
            AnimalsInHabitat = _habitat;
        }

        public Animal[] AnimalsInHabitat { get; }
        public void Add(string name)
        {
            _habitat[_counter] = _animalProvider.AllAnimals.FindByName(name);
            _counter++;
        }
    }
}
