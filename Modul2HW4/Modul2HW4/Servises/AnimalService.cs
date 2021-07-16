using System;
using Modul2HW4.Servises.Abstractions;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Models;
using Modul2HW4.Enums;

namespace Modul2HW4.Servises
{
    public class AnimalService : IAnimalService
    {
        private readonly IConfigService _config;
        private readonly IAnimalProvider _animalProvider;
        public AnimalService(IAnimalProvider animalProvider, IConfigService config)
        {
            _config = config;
            _animalProvider = animalProvider;
            Animals = GetAll();
        }

        public Animal[] Animals { get; }

        private Animal[] GetAll()
        {
            var animals = _animalProvider.AllAnimals;
            Convert(animals);
            return animals;
        }

        private void Convert(Animal[] animals)
        {
            foreach (var item in animals)
            {
                var weightUnit = GetWeightData(item.WeightUnits);
                var speedUnit = GetSpeedData(item.SpeedUnits);
                item.Weight = item.Weight * weightUnit.RateDefaultToWeight;
                item.Speed = item.Speed * speedUnit.RateDefaultToSpeed;
            }
        }

        private WeightUnitsData GetWeightData(WeightUnits weightUnits)
        {
            foreach (var item in _config.ConfigSettings.WeightUnitsDatas)
            {
                if (item.WeightUnits == weightUnits)
                {
                    return item;
                }
            }

            return null;
        }

        private SpeedUnitsData GetSpeedData(SpeedUnits speedUnits)
        {
            foreach (var item in _config.ConfigSettings.SpeedUnitsDatas)
            {
                if (item.SpeedUnits == speedUnits)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
