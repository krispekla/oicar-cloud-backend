using System;
using System.Collections.Generic;
using System.Text;

namespace Oicar.Dal.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Created = DateTime.Now;
            Modified = DateTime.Now;
        }

        public int Id { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
