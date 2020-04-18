using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstatisticTimes
    {
        public TstatisticTimes()
        {
            Estatistic = new HashSet<Estatistic>();
        }

        public long TstatisticTimesId { get; set; }
        public DateTime ArrivalValue { get; set; }
        public bool ArrivalValueSpecified { get; set; }
        public string ArrivalDay { get; set; }
        public DateTime DepartureValue { get; set; }
        public bool DepartureValueSpecified { get; set; }
        public string DepartureDay { get; set; }
        public string ArrivalDelay { get; set; }
        public string DepartureDelay { get; set; }
        public string StopTime { get; set; }

        public virtual ICollection<Estatistic> Estatistic { get; set; }
    }
}
