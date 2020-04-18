using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EelectrificationChanges
    {
        public EelectrificationChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EelectrificationChangesId { get; set; }
        public short ElectrificationChange { get; set; }

        public virtual TelectrificationChange ElectrificationChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
