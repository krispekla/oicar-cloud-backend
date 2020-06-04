using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Service.Models
{
    public class CloudCombinationStatisticDTO : CloudCombinationDTO
    {
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public int TotalCombinations { get; set; }
        public string Provider { get; set; }
    }
}
