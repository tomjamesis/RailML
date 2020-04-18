using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Esignals
    {
        public Esignals()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EsignalsId { get; set; }
        public short Signal { get; set; }
        public long SignalGroups { get; set; }

        public virtual EsignalGroups SignalGroupsNavigation { get; set; }
        public virtual Tsignal SignalNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
