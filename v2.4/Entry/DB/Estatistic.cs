using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Estatistic
    {
        public Estatistic()
        {
            Estatistics = new HashSet<Estatistics>();
        }

        public short EstatisticId { get; set; }
        public long Mean { get; set; }
        public long Median { get; set; }
        public long StandardDeviation { get; set; }
        public long StatisticAnalyses { get; set; }

        public virtual TstatisticTimes MeanNavigation { get; set; }
        public virtual TstandardDeviationTimes StandardDeviationNavigation { get; set; }
        public virtual TstatisticAnalyses StatisticAnalysesNavigation { get; set; }
        public virtual ICollection<Estatistics> Estatistics { get; set; }
    }
}
