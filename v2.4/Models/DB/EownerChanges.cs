using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EownerChanges
    {
        public EownerChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EownerChangesId { get; set; }
        public short OwnerChange { get; set; }

        public virtual TownerChange OwnerChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
