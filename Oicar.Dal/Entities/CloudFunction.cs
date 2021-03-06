﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Entities
{
    public class CloudFunction : BaseEntity
    {
        public int ExecutinPerRequestInMiliseconds { get; set; }
        public int MemorySizeInMB { get; set; }
        public double ExecutionsPerMonth { get; set; }
        public CloudProvider CloudProvider { get; set; }
        public double Price { get; set; }

        public virtual List<UserCloud> UserCloud { get; set; }
    }
}
