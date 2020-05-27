using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Oicar.Dal.Entities
{
    public class UserCloud : BaseEntity
    {
        [Column(TypeName = "json")]
        public string UserInput { get; set; }

        public User User { get; set; }
        public CloudDbSQL CloudDbSQL { get; set; }
        public CloudFunction CloudFunction { get; set; }
        public CloudStorage CloudStorage { get; set; }
        public CloudVM CloudVM { get; set; }
        public bool IsActive { get; set; }
    }
}
