using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EloadLimit
    {
        public EloadLimit()
        {
            EloadLimitMatrix = new HashSet<EloadLimitMatrix>();
        }

        public short EloadLimitId { get; set; }
        public long RailNetwork { get; set; }
        public long LineClassification { get; set; }

        public virtual TlineClassification LineClassificationNavigation { get; set; }
        public virtual TrailNetwork RailNetworkNavigation { get; set; }
        public virtual ICollection<EloadLimitMatrix> EloadLimitMatrix { get; set; }
    }
}
