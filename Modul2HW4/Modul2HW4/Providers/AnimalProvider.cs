using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4.Providers
{
    public class AnimalProvider : IAnimalProvider
    {
        public Animal[] GetAnimals()
        {
            return new Animal[]
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
                    Name = "Eagle",
                    HasFlyingSkill = true,
                    Sex = Sex.FEMALE,
                    Speed = 42,
                    Weight = 1.2
                }
            };
        }
    }
}
