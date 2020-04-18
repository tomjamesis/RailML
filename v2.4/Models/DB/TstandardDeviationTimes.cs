using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstandardDeviationTimes
    {
        public TstandardDeviationTimes()
        {
            Estatistic = new HashSet<Estatistic>();
        }

        public long TstandardDeviationTimesId { get; set; }
        public string ArrivalDelay { get; set; }
        public string DepartureDelay { get; set; }

        public virtual ICollection<Estatistic> Estatistic { get; set; }
    }
}
