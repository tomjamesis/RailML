using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EocpsTt
    {
        public EocpsTt()
        {
            EtrainPart = new HashSet<EtrainPart>();
        }

        public long EocpsTtid { get; set; }
        public short OcpTt { get; set; }

        public virtual EocpTt OcpTtNavigation { get; set; }
        public virtual ICollection<EtrainPart> EtrainPart { get; set; }
    }
}
