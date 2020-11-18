using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TsectionTt
    {
        public long TsectionTtid { get; set; }
        public string Any { get; set; }
        public string Section { get; set; }
        public string LineRef { get; set; }
        public string TrackInfo { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public decimal PercentageSupplementValue { get; set; }
        public bool PercentageSupplementValueSpecified { get; set; }
        public decimal DistanceValue { get; set; }
        public bool DistanceValueSpecified { get; set; }
    }
}
