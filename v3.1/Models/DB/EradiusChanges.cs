using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EradiusChanges
    {
        public EradiusChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EradiusChangesId { get; set; }
        public short RadiusChange { get; set; }

        public virtual TradiusChange RadiusChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
