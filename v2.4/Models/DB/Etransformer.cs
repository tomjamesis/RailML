using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Etransformer
    {
        public Etransformer()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EtransformerId { get; set; }
        public long Winding { get; set; }
        public short Efficiency { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual Twinding WindingNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
