using System;
using System.Collections.Generic;

namespace Oicar.Dal.Entities
{
    public class NewsPost : BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public byte[] Image { get; set; }
        public string Content { get; set; }
    }
}
