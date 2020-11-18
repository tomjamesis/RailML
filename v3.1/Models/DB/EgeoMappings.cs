using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EgeoMappings
    {
        public EgeoMappings()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EgeoMappingsId { get; set; }
        public short GeoMapping { get; set; }

        public virtual TplacedElement GeoMappingNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
