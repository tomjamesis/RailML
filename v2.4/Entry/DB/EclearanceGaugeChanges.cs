using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EclearanceGaugeChanges
    {
        public EclearanceGaugeChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EclearanceGaugeChangesId { get; set; }
        public short ClearanceGaugeChange { get; set; }

        public virtual TclearanceGaugeChange ClearanceGaugeChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
