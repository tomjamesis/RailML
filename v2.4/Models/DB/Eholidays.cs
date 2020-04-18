using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eholidays
    {
        public Eholidays()
        {
            EtimetablePeriod = new HashSet<EtimetablePeriod>();
        }

        public long EholidaysId { get; set; }
        public long Holiday { get; set; }

        public virtual Tholiday HolidayNavigation { get; set; }
        public virtual ICollection<EtimetablePeriod> EtimetablePeriod { get; set; }
    }
}
