using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackTopology
    {
        public EtrackTopology()
        {
            Etrack = new HashSet<Etrack>();
        }

        public long EtrackTopologyId { get; set; }
        public short TrackBegin { get; set; }
        public short TrackEnd { get; set; }
        public long MileageChanges { get; set; }
        public long Connections { get; set; }
        public long CrossSections { get; set; }
        public long Borders { get; set; }

        public virtual Eborder BordersNavigation { get; set; }
        public virtual Econnections ConnectionsNavigation { get; set; }
        public virtual EcrossSections CrossSectionsNavigation { get; set; }
        public virtual EmileageChanges MileageChangesNavigation { get; set; }
        public virtual EtrackBegin TrackBeginNavigation { get; set; }
        public virtual EtrackEnd TrackEndNavigation { get; set; }
        public virtual ICollection<Etrack> Etrack { get; set; }
    }
}
