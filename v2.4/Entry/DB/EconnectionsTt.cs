using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EconnectionsTt
    {
        public EconnectionsTt()
        {
            EocpTt = new HashSet<EocpTt>();
        }

        public long EconnectionsTtid { get; set; }
        public short Connection { get; set; }

        public virtual EconnectionTt ConnectionNavigation { get; set; }
        public virtual ICollection<EocpTt> EocpTt { get; set; }
    }
}
