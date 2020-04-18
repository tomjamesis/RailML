using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EinfrastructureVisualization
    {
        public EinfrastructureVisualization()
        {
            InfrastructureVisualizations = new HashSet<InfrastructureVisualizations>();
        }

        public short EinfrastructureVisualizationId { get; set; }
        public short LineVis { get; set; }
        public short OcpVis { get; set; }

        public virtual ElineVis LineVisNavigation { get; set; }
        public virtual EocpVis OcpVisNavigation { get; set; }
        public virtual ICollection<InfrastructureVisualizations> InfrastructureVisualizations { get; set; }
    }
}
