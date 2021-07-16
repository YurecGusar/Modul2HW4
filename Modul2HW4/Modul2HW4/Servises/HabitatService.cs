using Modul2HW4.Models;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4.Servises
{
    public class HabitatService : IHabitatService
    {
        private readonly IConfigService _config;
        private readonly IAnimalService _animalService;
        private Animal[] _habitat;
        private int _counter = 0;

        public HabitatService(IAnimalService animalService, IConfigService config)
        {
            _config = config;
            _animalService = animalService;
            _habitat = new Animal[_config.MaxAnimalsInHabitat];
            AnimalsInHabitat = _habitat;
        }

        public Animal[] AnimalsInHabitat { get; }
        public void Add(string name)
        {
            _habitat[_counter] = _animalService.Animals.FindByName(name);
            _counter++;
        }

        public void CountAnimalTypes()
        {
            foreach (var item in _habitat)
            {
            }
        }
    }
}
