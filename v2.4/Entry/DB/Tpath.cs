using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tpath
    {
        public Tpath()
        {
            TspeedProfile = new HashSet<TspeedProfile>();
        }

        public long TpathId { get; set; }
        public short OcpRef { get; set; }

        public virtual TocpRefInGroup OcpRefNavigation { get; set; }
        public virtual ICollection<TspeedProfile> TspeedProfile { get; set; }
    }
}
