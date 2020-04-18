using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eline
    {
        public Eline()
        {
            EtrackGroups = new HashSet<EtrackGroups>();
        }

        public short ElineId { get; set; }
        public string LineDescr { get; set; }
        public short TrackRef { get; set; }

        public virtual TtrackRefInGroup TrackRefNavigation { get; set; }
        public virtual ICollection<EtrackGroups> EtrackGroups { get; set; }
    }
}
