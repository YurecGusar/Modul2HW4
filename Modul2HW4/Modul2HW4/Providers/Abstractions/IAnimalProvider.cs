using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Providers.Abstractions
{
    public interface IAnimalProvider
    {
        public Animal[] AllAnimals { get; set; }
    }
}
