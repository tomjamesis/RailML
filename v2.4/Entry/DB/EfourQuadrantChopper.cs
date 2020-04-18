using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EfourQuadrantChopper
    {
        public EfourQuadrantChopper()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EfourQuadrantChopperId { get; set; }
        public short Efficiency { get; set; }
        public long Phi { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual Tcurve PhiNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
