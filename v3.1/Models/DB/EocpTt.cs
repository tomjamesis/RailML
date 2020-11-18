using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EocpTt
    {
        public EocpTt()
        {
            EocpsTt = new HashSet<EocpsTt>();
        }

        public short EocpTtid { get; set; }
        public short Times { get; set; }
        public long Connections { get; set; }
        public long Statistics { get; set; }
        public short SectionTt { get; set; }
        public short StopDescription { get; set; }
        public string Any { get; set; }

        public virtual EconnectionsTt ConnectionsNavigation { get; set; }
        public virtual EsectionTt SectionTtNavigation { get; set; }
        public virtual Estatistics StatisticsNavigation { get; set; }
        public virtual EstopDescription StopDescriptionNavigation { get; set; }
        public virtual EarrivalDepartureTimes TimesNavigation { get; set; }
        public virtual ICollection<EocpsTt> EocpsTt { get; set; }
    }
}
