using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TarrivalDepartureTimes
    {
        public long TarrivalDepartureTimesId { get; set; }
        public string Scope { get; set; }
        public DateTime ArrivalValue { get; set; }
        public bool ArrivalValueSpecified { get; set; }
        public string ArrivalDay { get; set; }
        public DateTime DepartureValue { get; set; }
        public bool DepartureValueSpecified { get; set; }
        public string DepartureDay { get; set; }
    }
}
