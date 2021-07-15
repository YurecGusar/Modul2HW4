using System;
using Modul2HW4.Extension;
using Modul2HW4.Providers.Abstractions;

namespace Modul2HW4
{
    public class Starter
    {
        private readonly IAnimalProvider _animalProvider;
        public Starter(IAnimalProvider animalProvider)
        {
            _animalProvider = animalProvider;
        }

        public void Run()
        {
            Console.WriteLine(_animalProvider.AllAnimals.FindByName("Юго-западный африканский лев") is Feline);
        }
    }
}
