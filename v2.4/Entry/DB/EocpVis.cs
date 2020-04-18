using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EocpVis
    {
        public EocpVis()
        {
            EinfrastructureVisualization = new HashSet<EinfrastructureVisualization>();
        }

        public short EocpVisId { get; set; }
        public long Position { get; set; }
        public long Size { get; set; }

        public virtual Tpoint PositionNavigation { get; set; }
        public virtual Tsize SizeNavigation { get; set; }
        public virtual ICollection<EinfrastructureVisualization> EinfrastructureVisualization { get; set; }
    }
}
