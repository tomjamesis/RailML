using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EequipmentUsage
    {
        public EequipmentUsage()
        {
            EformationTt = new HashSet<EformationTt>();
            EtrainPartSequence = new HashSet<EtrainPartSequence>();
        }

        public long EequipmentUsageId { get; set; }
        public short Equipment { get; set; }

        public virtual Eequipment EquipmentNavigation { get; set; }
        public virtual ICollection<EformationTt> EformationTt { get; set; }
        public virtual ICollection<EtrainPartSequence> EtrainPartSequence { get; set; }
    }
}
