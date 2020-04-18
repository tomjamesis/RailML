using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EgaugeChanges
    {
        public EgaugeChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EgaugeChangesId { get; set; }
        public short GaugeChange { get; set; }

        public virtual TgaugeChange GaugeChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
