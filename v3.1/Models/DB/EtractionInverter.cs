using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtractionInverter
    {
        public EtractionInverter()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EtractionInverterId { get; set; }
        public short Efficiency { get; set; }
        public long PulsePattern { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual EpulsePattern PulsePatternNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
