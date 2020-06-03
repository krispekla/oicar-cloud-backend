using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Service.Models
{
    public class CloudCombinationResultDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CloudCombinationDTO CloudCombinationInput { get; set; }
        public CloudCombinationDTO CloudCombinationResult { get; set; }
        public int UserId { get; set; }
    }
}
