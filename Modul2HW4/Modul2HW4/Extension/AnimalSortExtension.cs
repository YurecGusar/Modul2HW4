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
            var a1 = animal1 as Animal;
            var a2 = animal2 as Animal;
            if (a1 != null && a2 != null)
            {
                if (a1.Speed > a2.Speed)
                {
                    return 1;
                }
                else if (a1.Speed < a2.Speed)
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
