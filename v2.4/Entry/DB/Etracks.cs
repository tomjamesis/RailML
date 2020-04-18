using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Etracks
    {
        public Etracks()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EtracksId { get; set; }
        public short Track { get; set; }

        public virtual Etrack TrackNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
