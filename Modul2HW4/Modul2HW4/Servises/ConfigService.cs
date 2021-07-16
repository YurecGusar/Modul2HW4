using Modul2HW4.Models;
using Modul2HW4.Enums;
using Modul2HW4.Servises.Abstractions;

namespace Modul2HW4.Servises
{
    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
            var config = GetConfig();
            ConfigSettings = config.ConfigSettings;
            MaxAnimalsInHabitat = config.MaxAnimalsInHabitat;
        }

        public int MaxAnimalsInHabitat { get; }
        public Config.ConfigSettings ConfigSettings { get; }
        private Config.Config GetConfig()
        {
            return new Config.Config
            {
                ConfigSettings = new Config.ConfigSettings
                {
                    SpeedUnitsDatas = new SpeedUnitsData[]
                {
                    new SpeedUnitsData
                    {
                        SpeedUnits = Enums.SpeedUnits.KlmtrsPreHr,
                        RateDefaultToSpeed = 1
                    },
                    new Models.SpeedUnitsData
                    {
                        SpeedUnits = Enums.SpeedUnits.MtrPreScnd,
                        RateDefaultToSpeed = 0.27
                    }
                },
                    WeightUnitsDatas = new WeightUnitsData[]
                {
                    new WeightUnitsData
                    {
                        WeightUnits = Enums.WeightUnits.KG,
                        RateDefaultToWeight = 1
                    },
                    new WeightUnitsData
                    {
                        WeightUnits = Enums.WeightUnits.GR,
                        RateDefaultToWeight = 1000
                    }
                },
                    CurrentSpeedUnits = Enums.SpeedUnits.KlmtrsPreHr,
                    CurrentWeightUnits = Enums.WeightUnits.KG
                },
                MaxAnimalsInHabitat = 10
            };
        }
    }
}
