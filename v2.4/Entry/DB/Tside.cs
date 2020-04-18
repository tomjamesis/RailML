using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tside
    {
        public Tside()
        {
            TbaseServiceSection = new HashSet<TbaseServiceSection>();
            Tderailer = new HashSet<Tderailer>();
        }

        public byte TsideId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TbaseServiceSection> TbaseServiceSection { get; set; }
        public virtual ICollection<Tderailer> Tderailer { get; set; }
    }
}
