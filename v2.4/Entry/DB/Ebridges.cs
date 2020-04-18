using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Ebridges
    {
        public Ebridges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EbridgesId { get; set; }
        public short Brigde { get; set; }

        public virtual Ebridge BrigdeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
