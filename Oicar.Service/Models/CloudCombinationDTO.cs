using Oicar.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Service.Models
{
    public class CloudCombinationDTO
    {
        public CloudDbSQL CloudDbSQL { get; set; }
        public CloudFunction CloudFunction { get; set; }
        public CloudStorage CloudStorage { get; set; }
        public CloudVM CloudVM { get; set; }
    }
}
