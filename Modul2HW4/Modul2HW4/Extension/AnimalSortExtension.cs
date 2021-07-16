using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Extension
{
    public class AnimalSortExtension : IComparer
    {
        public int Compare(object animal1, object animal2)
        {
            var a1 = (Animal)animal1;
            var a2 = (Animal)animal2;
            if (a1 != null && a2 != null)
            {
                if (a1.Name.Length > a2.Name.Length)
                {
                    return 1;
                }
                else if (a1.Name.Length < a2.Name.Length)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
