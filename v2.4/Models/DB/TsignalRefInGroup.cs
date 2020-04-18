using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsignalRefInGroup
    {
        public TsignalRefInGroup()
        {
            EsignalGroup = new HashSet<EsignalGroup>();
        }

        public short TsignalRefInGroupId { get; set; }

        public virtual ICollection<EsignalGroup> EsignalGroup { get; set; }
    }
}
