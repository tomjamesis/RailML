using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Estatistics
    {
        public Estatistics()
        {
            EocpTt = new HashSet<EocpTt>();
        }

        public long EstatisticsId { get; set; }
        public short Statistic { get; set; }

        public virtual Estatistic StatisticNavigation { get; set; }
        public virtual ICollection<EocpTt> EocpTt { get; set; }
    }
}
