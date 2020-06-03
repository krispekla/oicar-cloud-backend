using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Oicar.Dal.Entities
{
    public class UserCloud : BaseEntity
    {
        [Column(TypeName = "json")]
        public string UserInput { get; set; }

        public string Name { get; set; }
        public virtual User User { get; set; }
        public virtual CloudDbSQL CloudDbSQL { get; set; }
        public virtual CloudFunction CloudFunction { get; set; }
        public virtual CloudStorage CloudStorage { get; set; }
        public virtual CloudVM CloudVM { get; set; }
        public bool IsActive { get; set; }
    }
}
