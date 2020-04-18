using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tlink
    {
        public Tlink()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public long TlinkId { get; set; }
        public decimal NominalVoltage { get; set; }
        public decimal NominalCurrent { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
