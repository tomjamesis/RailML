using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EocpPropOperational
    {
        public EocpPropOperational()
        {
            Eocp = new HashSet<Eocp>();
        }

        public short EocpPropOperationalId { get; set; }
        public short Uptime { get; set; }

        public virtual TocpUptime UptimeNavigation { get; set; }
        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
