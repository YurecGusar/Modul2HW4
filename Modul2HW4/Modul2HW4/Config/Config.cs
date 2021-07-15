using Modul2HW4.Enums;
using Modul2HW4.Models;

namespace Modul2HW4
{
    public class Config
    {
        public WeightUnitsData[] WeightUnitsData { get; set; }
        public SpeedUnitsData[] SpeedUnitsData { get; set; }
        public WeightUnits CurrentWU { get; set; }
        public SpeedUnits CurrentSU { get; set; }
    }
}
