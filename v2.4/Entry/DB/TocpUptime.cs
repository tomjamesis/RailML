using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TocpUptime
    {
        public TocpUptime()
        {
            EocpPropOperational = new HashSet<EocpPropOperational>();
        }

        public short TocpUptimeId { get; set; }
        public string Mode { get; set; }

        public virtual ICollection<EocpPropOperational> EocpPropOperational { get; set; }
    }
}
