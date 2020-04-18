using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainProtectionChanges
    {
        public EtrainProtectionChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EtrainProtectionChangesId { get; set; }
        public short TrainProtectionChange { get; set; }

        public virtual TtrainProtectionChange TrainProtectionChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
