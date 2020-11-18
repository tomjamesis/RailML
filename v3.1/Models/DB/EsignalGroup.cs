using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EsignalGroup
    {
        public EsignalGroup()
        {
            EsignalGroups = new HashSet<EsignalGroups>();
        }

        public short EsignalGroupId { get; set; }
        public short SignalRef { get; set; }

        public virtual TsignalRefInGroup SignalRefNavigation { get; set; }
        public virtual ICollection<EsignalGroups> EsignalGroups { get; set; }
    }
}
