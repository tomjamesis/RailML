using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EpulsePattern
    {
        public EpulsePattern()
        {
            EtractionInverter = new HashSet<EtractionInverter>();
        }

        public long EpulsePatternId { get; set; }
        public short ValueTable { get; set; }

        public virtual EpulsePatternValueTable ValueTableNavigation { get; set; }
        public virtual ICollection<EtractionInverter> EtractionInverter { get; set; }
    }
}
