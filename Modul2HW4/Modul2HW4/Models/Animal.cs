using Modul2HW4.Enums;

namespace Modul2HW4
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Speed { get; set; }
        public Sex Sex { get; set; }
        public WeightUnits[] WeightUnits { get; set; }
        public SpeedUnits[] SpeedUnits { get; set; }
    }
}
