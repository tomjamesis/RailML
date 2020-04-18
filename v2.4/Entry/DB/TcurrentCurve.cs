using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TcurrentCurve
    {
        public TcurrentCurve()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short TcurrentCurveId { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
