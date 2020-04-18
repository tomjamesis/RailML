using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EocpPropEquipment
    {
        public EocpPropEquipment()
        {
            Eocp = new HashSet<Eocp>();
        }

        public long EocpPropEquipmentId { get; set; }
        public long Summary { get; set; }
        public short TrackRef { get; set; }

        public virtual TocpPropEquipmentSummary SummaryNavigation { get; set; }
        public virtual TtrackRefInGroup TrackRefNavigation { get; set; }
        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
