using System.Collections.Generic;

namespace Oicar.Dal.Entities
{
    public enum OperatingSystem
    {
        Windows,
        Linux
    }

    public enum StorageType
    {
        HDD,
        SSD
    }
    public class CloudVM : BaseEntity
    {
        public int InstanceNb { get; set; }
        public OperatingSystem OperatingSystem { get; set; }
        public int Core { get; set; }
        public int Ram { get; set; }
        public double Storage { get; set; }
        public StorageType StorageType { get; set; }
        public int AverageHoursPerDay { get; set; }
        public int AverageDaysPerWeek { get; set; }
        public CloudProvider CloudProvider { get; set; }
        public double Price { get; set; }

        public virtual List<UserCloud> UserCloud { get; set; }
    }
}
