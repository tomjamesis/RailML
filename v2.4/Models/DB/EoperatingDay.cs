using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EoperatingDay
    {
        public EoperatingDay()
        {
            EoperatingPeriod = new HashSet<EoperatingPeriod>();
        }

        public short EoperatingDayId { get; set; }
        public long OperatingDayDeviance { get; set; }

        public virtual ToperatingDayDeviance OperatingDayDevianceNavigation { get; set; }
        public virtual ICollection<EoperatingPeriod> EoperatingPeriod { get; set; }
    }
}
