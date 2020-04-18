using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpPropEquipmentSummary
    {
        public TocpPropEquipmentSummary()
        {
            EocpPropEquipment = new HashSet<EocpPropEquipment>();
        }

        public long TocpPropEquipmentSummaryId { get; set; }
        public byte SignalBoxValue { get; set; }
        public bool SignalBoxValueSpecified { get; set; }
        public bool Powerstation { get; set; }
        public bool HasHomeSignals { get; set; }
        public bool HasStarterSignals { get; set; }
        public bool HasSwitches { get; set; }

        public virtual TinterlockingTypes SignalBoxValueNavigation { get; set; }
        public virtual ICollection<EocpPropEquipment> EocpPropEquipment { get; set; }
    }
}
