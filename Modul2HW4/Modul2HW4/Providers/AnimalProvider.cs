using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers.Abstractions;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        private readonly IConfigService _config;
        public AnimalProvider(IConfigService config)
        {
            _config = config;

            AllAnimals = new Animal[]
            {
                new Feline
                {
                    Name = "Юго-западный африканский лев",
                    Weight = 190,
                    Sex = Sex.MALE,
                    Speed = 80,
                    FurColor = Colors.ORANGE,
                    WayOfLife = WayOfLife.SETTLED,
                    FelineSpecies = FelineSpecies.LION
                },
                new Canine
                {
                    Name = "Шакал обыкновенный",
                    Weight = 11,
                    Sex = Sex.FEMALE,
                    Speed = 16,
                    FurColor = Colors.GREY,
                    WayOfLife = WayOfLife.SETTLED,
                    CanineSpecies = CanineSpecies.JACKAL
                },
                new Bovids
                {
                    Name = "Дорпер",
                    Weight = 120,
                    Sex = Sex.MALE,
                    Speed = 40,
                    FurColor = Colors.BLACK,
                    HoofToes = HoofToes.DOUBLE,
                    HornLength = 30,
                    Species = BovidsSpecies.RAM
                },
                new Bird
                {
                    Name = "Орел",
                    HasFlyingSkill = true,
                    Sex = Sex.FEMALE,
                    Speed = 42,
                    Weight = 1.2
                }
            };
            GetUnits();
        }

        public Animal[] AllAnimals { get; set; }

        private void GetUnits()
        {
            foreach (var item in AllAnimals)
            {
                item.SpeedUnits = _config.ConfigSettings.CurrentSpeedUnits;
                item.WeightUnits = _config.ConfigSettings.CurrentWeightUnits;
            }
        }
    }
}
