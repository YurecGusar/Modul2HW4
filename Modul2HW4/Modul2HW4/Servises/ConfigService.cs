using System;
using Modul2HW4.Servises.Abstractions;
using Modul2HW4.Enums;
using Modul2HW4.Models;

namespace Modul2HW4.Servises
{
    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
            Config = GetConfig();
        }

        public Config Config { get; }

        public Config GetConfig()
        {
            return new Config
            {
                WeightUnitsData = new WeightUnitsData[]
                {
                    new WeightUnitsData
                    {
                        WeightUnits = WeightUnits.KG,
                        RateDefaultToWeight = 1
                    },
                    new WeightUnitsData
                    {
                        WeightUnits = WeightUnits.GR,
                        RateDefaultToWeight = 1000
                    }
                },
                SpeedUnitsData = new SpeedUnitsData[]
                {
                    new SpeedUnitsData
                    {
                        SpeedUnits = SpeedUnits.KlmtrsPreHr,
                        RateDefaultToSpeed = 1
                    },
                    new SpeedUnitsData
                    {
                        SpeedUnits = SpeedUnits.MtrPreScnd,
                        RateDefaultToSpeed = 0.27
                    }
                },
                CurrentSU = SpeedUnits.KlmtrsPreHr,
                CurrentWU = WeightUnits.KG
            };
        }
    }
}
