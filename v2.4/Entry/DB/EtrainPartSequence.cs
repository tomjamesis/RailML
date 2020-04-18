using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrainPartSequence
    {
        public EtrainPartSequence()
        {
            Etrain = new HashSet<Etrain>();
        }

        public short EtrainPartSequenceId { get; set; }
        public short TrainPartRef { get; set; }
        public short SpeedProfileRef { get; set; }
        public long EquipmentUsage { get; set; }
        public short BrakeUsage { get; set; }
        public long TopologyReference { get; set; }

        public virtual EbrakeUsage BrakeUsageNavigation { get; set; }
        public virtual EequipmentUsage EquipmentUsageNavigation { get; set; }
        public virtual TspeedProfileRef SpeedProfileRefNavigation { get; set; }
        public virtual TtopologyReference TopologyReferenceNavigation { get; set; }
        public virtual TtrainPartRef TrainPartRefNavigation { get; set; }
        public virtual ICollection<Etrain> Etrain { get; set; }
    }
}
