using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EoperationModeChanges
    {
        public EoperationModeChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EoperationModeChangesId { get; set; }
        public short OperationModeChange { get; set; }

        public virtual ToperationModeChange OperationModeChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
