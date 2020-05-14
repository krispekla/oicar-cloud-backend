using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Entities
{
    public enum SQLServerType
    {
        Standard2017,
        Enterprise2017,
        Express2017,
        Web2017
    }
    public class CloudDbSQL : BaseEntity
    {
        public int Instance { get; set; }
        public int Ram { get; set; }
        public int CpuCores { get; set; }
        public int BaskupSize { get; set; }
        public int AverageHoursPerDay { get; set; }
        public int AverageDaysPerWeek { get; set; }
        public SQLServerType SQLServerType { get; set; }
        public Location Location { get; set; }
        public double Price { get; set; }
    }
}
