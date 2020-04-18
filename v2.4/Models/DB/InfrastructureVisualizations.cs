using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class InfrastructureVisualizations
    {
        public InfrastructureVisualizations()
        {
            Railml = new HashSet<Railml>();
        }

        public long InfrastructureVisualizationsId { get; set; }
        public short Visualization { get; set; }
        public string Base { get; set; }

        public virtual EinfrastructureVisualization VisualizationNavigation { get; set; }
        public virtual ICollection<Railml> Railml { get; set; }
    }
}
