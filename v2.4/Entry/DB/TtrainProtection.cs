using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainProtection
    {
        public TtrainProtection()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TtrainProtectionId { get; set; }
        public byte Monitoring { get; set; }
        public byte MediumValue { get; set; }
        public bool MediumValueSpecified { get; set; }

        public virtual TtrainProtectionMedium MediumValueNavigation { get; set; }
        public virtual TtrainProtectionMonitoring MonitoringNavigation { get; set; }
        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
