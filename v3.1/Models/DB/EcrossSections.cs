using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EcrossSections
    {
        public EcrossSections()
        {
            EtrackTopology = new HashSet<EtrackTopology>();
        }

        public long EcrossSectionsId { get; set; }
        public short CrossSection { get; set; }

        public virtual TcrossSection CrossSectionNavigation { get; set; }
        public virtual ICollection<EtrackTopology> EtrackTopology { get; set; }
    }
}
