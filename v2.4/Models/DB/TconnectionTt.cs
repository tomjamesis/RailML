using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TconnectionTt
    {
        public long TconnectionTtid { get; set; }
        public string Any { get; set; }
        public string TrainRef { get; set; }
        public string MinConnTime { get; set; }
        public string MaxConnTime { get; set; }
        public string ConnOperation { get; set; }
        public string ConnType { get; set; }
        public string OcpRef { get; set; }
        public string TrainPartRef { get; set; }
        public string OperatingPeriodRef { get; set; }
        public bool NotGuaranteedValue { get; set; }
        public bool NotGuaranteedValueSpecified { get; set; }
        public bool NonConnectionValue { get; set; }
        public bool NonConnectionValueSpecified { get; set; }
        public bool SamePlatformValue { get; set; }
        public bool SamePlatformValueSpecified { get; set; }
    }
}
