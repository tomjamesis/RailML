using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ElineVis
    {
        public ElineVis()
        {
            EinfrastructureVisualization = new HashSet<EinfrastructureVisualization>();
        }

        public short ElineVisId { get; set; }
        public short TrackVis { get; set; }

        public virtual EtrackVis TrackVisNavigation { get; set; }
        public virtual ICollection<EinfrastructureVisualization> EinfrastructureVisualization { get; set; }
    }
}
