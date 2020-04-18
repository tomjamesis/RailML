using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainProtectionChange
    {
        public TtrainProtectionChange()
        {
            EtrainProtectionChanges = new HashSet<EtrainProtectionChanges>();
        }

        public short TtrainProtectionChangeId { get; set; }
        public byte Monitoring { get; set; }
        public byte MediumValue { get; set; }
        public bool MediumValueSpecified { get; set; }

        public virtual TtrainProtectionMedium MediumValueNavigation { get; set; }
        public virtual TtrainProtectionMonitoring MonitoringNavigation { get; set; }
        public virtual ICollection<EtrainProtectionChanges> EtrainProtectionChanges { get; set; }
    }
}
