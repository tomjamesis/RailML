using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EspeedChanges
    {
        public EspeedChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EspeedChangesId { get; set; }
        public short SpeedChange { get; set; }

        public virtual TspeedChange SpeedChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
