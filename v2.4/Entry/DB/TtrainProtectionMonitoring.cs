using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainProtectionMonitoring
    {
        public TtrainProtectionMonitoring()
        {
            TnationalSystem = new HashSet<TnationalSystem>();
            TtrainProtection = new HashSet<TtrainProtection>();
            TtrainProtectionChange = new HashSet<TtrainProtectionChange>();
        }

        public byte TtrainProtectionMonitoringId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TnationalSystem> TnationalSystem { get; set; }
        public virtual ICollection<TtrainProtection> TtrainProtection { get; set; }
        public virtual ICollection<TtrainProtectionChange> TtrainProtectionChange { get; set; }
    }
}
