using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TcurveValueTable
    {
        public TcurveValueTable()
        {
            Tcurve = new HashSet<Tcurve>();
        }

        public short TcurveValueTableId { get; set; }

        public virtual ICollection<Tcurve> Tcurve { get; set; }
    }
}
