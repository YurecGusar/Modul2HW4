using Modul2HW4.Enums;

namespace Modul2HW4.Servises.Abstractions
{
    public interface IConfigService
    {
        public int MaxAnimalsInHabitat { get; }
        public Config.ConfigSettings ConfigSettings { get; }
        public Config.Config GetConfig();
    }
}
