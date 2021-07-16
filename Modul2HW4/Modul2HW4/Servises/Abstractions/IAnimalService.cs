using Modul2HW4.Enums;
using Modul2HW4.Models;

namespace Modul2HW4.Servises.Abstractions
{
    public interface IAnimalService
    {
        public Animal[] Animals { get; }
        public Animal[] GetAll();
        public void Convert(Animal[] animals);
        public WeightUnitsData GetWeightData(WeightUnits weightUnits);
        public SpeedUnitsData GetSpeedData(SpeedUnits speedUnits);
    }
}
