using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Extension
{
    public static class FindAnimalByNameExtension
    {
        public static Animal FindByName(this Animal[] animals, string name)
        {
            foreach (var item in animals)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
