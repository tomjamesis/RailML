using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TclearanceGaugeChange
    {
        public TclearanceGaugeChange()
        {
            EclearanceGaugeChanges = new HashSet<EclearanceGaugeChanges>();
        }

        public short TclearanceGaugeChangeId { get; set; }
        public long ClearanceGauge { get; set; }

        public virtual TclearanceGaugeType ClearanceGaugeNavigation { get; set; }
        public virtual ICollection<EclearanceGaugeChanges> EclearanceGaugeChanges { get; set; }
    }
}
