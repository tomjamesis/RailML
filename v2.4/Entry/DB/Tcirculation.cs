using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tcirculation
    {
        public Tcirculation()
        {
            Ecirculations = new HashSet<Ecirculations>();
        }

        public long TcirculationId { get; set; }
        public string BlockRef { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
        public string OperatingPeriodRef { get; set; }
        public string RepeatCount { get; set; }
        public string VehicleCounter { get; set; }
        public string VehicleGroupCounter { get; set; }
        public string NextBlockRef { get; set; }
        public string NextOperatingPeriodRef { get; set; }

        public virtual ICollection<Ecirculations> Ecirculations { get; set; }
    }
}
