using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TmaintenanceInterval
    {
        public TmaintenanceInterval()
        {
            EmaintenanceIntervals = new HashSet<EmaintenanceIntervals>();
        }

        public short TmaintenanceIntervalId { get; set; }
        public string MaximumIntervalDays { get; set; }
        public decimal MaximumIntervalDistanceValue { get; set; }
        public bool MaximumIntervalDistanceValueSpecified { get; set; }

        public virtual ICollection<EmaintenanceIntervals> EmaintenanceIntervals { get; set; }
    }
}
