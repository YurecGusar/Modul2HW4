using Modul2HW4.Enums;
using Modul2HW4.Models;

namespace Modul2HW4.Config
{
    public class ConfigSettings
    {
        public WeightUnitsData[] WeightUnitsDatas { get; set; }
        public SpeedUnitsData[] SpeedUnitsDatas { get; set; }
        public WeightUnits CurrentWeightUnits { get; set; }
        public SpeedUnits CurrentSpeedUnits { get; set; }
    }
}
