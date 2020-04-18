using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ElevelCrossings
    {
        public ElevelCrossings()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long ElevelCrossingsId { get; set; }
        public short LevelCrossing { get; set; }

        public virtual ElevelCrossing LevelCrossingNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
