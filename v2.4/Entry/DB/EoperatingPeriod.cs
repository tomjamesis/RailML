using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EoperatingPeriod
    {
        public EoperatingPeriod()
        {
            EoperatingPeriods = new HashSet<EoperatingPeriods>();
        }

        public short EoperatingPeriodId { get; set; }
        public short OperatingDay { get; set; }
        public long SpecialService { get; set; }

        public virtual EoperatingDay OperatingDayNavigation { get; set; }
        public virtual TspecialService SpecialServiceNavigation { get; set; }
        public virtual ICollection<EoperatingPeriods> EoperatingPeriods { get; set; }
    }
}
