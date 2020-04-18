using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrackVis
    {
        public EtrackVis()
        {
            ElineVis = new HashSet<ElineVis>();
        }

        public short EtrackVisId { get; set; }
        public short TrackElementVis { get; set; }

        public virtual EtrackElementVis TrackElementVisNavigation { get; set; }
        public virtual ICollection<ElineVis> ElineVis { get; set; }
    }
}
