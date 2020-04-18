using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtimetablePeriod
    {
        public EtimetablePeriod()
        {
            EtimetablePeriods = new HashSet<EtimetablePeriods>();
        }

        public short EtimetablePeriodId { get; set; }
        public long Holidays { get; set; }

        public virtual Eholidays HolidaysNavigation { get; set; }
        public virtual ICollection<EtimetablePeriods> EtimetablePeriods { get; set; }
    }
}
