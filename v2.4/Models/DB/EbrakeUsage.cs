using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EbrakeUsage
    {
        public EbrakeUsage()
        {
            EtrainPartSequence = new HashSet<EtrainPartSequence>();
        }

        public short EbrakeUsageId { get; set; }
        public string Any { get; set; }
        public string BrakePercentage { get; set; }
        public string RegularBrakePercentage { get; set; }
        public string EmergencyBrakePercentage { get; set; }

        public virtual ICollection<EtrainPartSequence> EtrainPartSequence { get; set; }
    }
}
