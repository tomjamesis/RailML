using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TbaliseRefInGroup
    {
        public TbaliseRefInGroup()
        {
            TbaliseGroup = new HashSet<TbaliseGroup>();
        }

        public short TbaliseRefInGroupId { get; set; }

        public virtual ICollection<TbaliseGroup> TbaliseGroup { get; set; }
    }
}
