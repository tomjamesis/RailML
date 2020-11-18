using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EarrivalDepartureTimes
    {
        public EarrivalDepartureTimes()
        {
            EocpTt = new HashSet<EocpTt>();
        }

        public short EarrivalDepartureTimesId { get; set; }

        public virtual ICollection<EocpTt> EocpTt { get; set; }
    }
}
