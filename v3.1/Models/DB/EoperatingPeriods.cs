using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EoperatingPeriods
    {
        public EoperatingPeriods()
        {
            Timetable = new HashSet<Timetable>();
        }

        public long EoperatingPeriodsId { get; set; }
        public short OperatingPeriod { get; set; }

        public virtual EoperatingPeriod OperatingPeriodNavigation { get; set; }
        public virtual ICollection<Timetable> Timetable { get; set; }
    }
}
