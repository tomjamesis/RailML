using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TeffortCurve
    {
        public TeffortCurve()
        {
            Epropulsion = new HashSet<Epropulsion>();
            EvehicleBrakes = new HashSet<EvehicleBrakes>();
        }

        public short TeffortCurveId { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
        public virtual ICollection<EvehicleBrakes> EvehicleBrakes { get; set; }
    }
}
