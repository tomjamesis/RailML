using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Etrack
    {
        public Etrack()
        {
            Etracks = new HashSet<Etracks>();
        }

        public short EtrackId { get; set; }
        public string TrackDescr { get; set; }
        public long TrackTopology { get; set; }
        public long TrackElements { get; set; }
        public long OcsElements { get; set; }
        public long InfraAttrGroupRefs { get; set; }
        public string Any { get; set; }

        public virtual EinfraAttrGroupRefs InfraAttrGroupRefsNavigation { get; set; }
        public virtual EocsElements OcsElementsNavigation { get; set; }
        public virtual EtrackElements TrackElementsNavigation { get; set; }
        public virtual EtrackTopology TrackTopologyNavigation { get; set; }
        public virtual ICollection<Etracks> Etracks { get; set; }
    }
}
