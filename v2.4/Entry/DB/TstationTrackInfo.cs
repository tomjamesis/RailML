using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstationTrackInfo
    {
        public TstationTrackInfo()
        {
            EstopDescription = new HashSet<EstopDescription>();
        }

        public long TstationTrackInfoId { get; set; }
        public string OperatingPeriodRef { get; set; }
        public string Track { get; set; }
        public string Platform { get; set; }

        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
    }
}
