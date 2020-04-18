using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Egear
    {
        public Egear()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EgearId { get; set; }
        public short Efficiency { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
