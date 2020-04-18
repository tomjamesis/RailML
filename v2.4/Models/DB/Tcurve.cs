using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tcurve
    {
        public Tcurve()
        {
            EfourQuadrantChopper = new HashSet<EfourQuadrantChopper>();
        }

        public long TcurveId { get; set; }
        public string Any { get; set; }
        public short ValueTable { get; set; }

        public virtual TcurveValueTable ValueTableNavigation { get; set; }
        public virtual ICollection<EfourQuadrantChopper> EfourQuadrantChopper { get; set; }
    }
}
