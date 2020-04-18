using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TnationalSystem
    {
        public TnationalSystem()
        {
            Emonitoring = new HashSet<Emonitoring>();
        }

        public short TnationalSystemId { get; set; }
        public string OnBoardUnitId { get; set; }
        public string SoftwareVersion { get; set; }
        public string Type { get; set; }
        public byte TrainProtectionMedium { get; set; }
        public byte TrainProtectionMonitoring { get; set; }

        public virtual TtrainProtectionMedium TrainProtectionMediumNavigation { get; set; }
        public virtual TtrainProtectionMonitoring TrainProtectionMonitoringNavigation { get; set; }
        public virtual ICollection<Emonitoring> Emonitoring { get; set; }
    }
}
