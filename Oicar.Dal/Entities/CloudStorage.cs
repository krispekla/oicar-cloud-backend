using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Entities
{
    public enum Location
    {
        Europe,
        America,
        Asia
    }

    public enum CloudProvider
    {
        AWS,
        AZURE,
        GCLOUD
    }

    public class CloudStorage : BaseEntity
    {
        public Location Location { get; set; }
        public double TotalAmount { get; set; }
        public double ReadOperationsPerMonth { get; set; }
        public double WriteOperationsPerMonth { get; set; }
        public CloudProvider CloudProvider { get; set; }
        public double Price { get; set; }
    }
}
