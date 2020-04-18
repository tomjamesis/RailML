using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TformationTt
    {
        public long TformationTtid { get; set; }
        public string Any { get; set; }
        public string FormationRef { get; set; }
        public decimal WeightValue { get; set; }
        public bool WeightValueSpecified { get; set; }
        public decimal LoadValue { get; set; }
        public bool LoadValueSpecified { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public decimal SpeedValue { get; set; }
        public bool SpeedValueSpecified { get; set; }
        public decimal TimetableLoadValue { get; set; }
        public bool TimetableLoadValueSpecified { get; set; }
        public bool OrientationReversedValue { get; set; }
        public bool OrientationReversedValueSpecified { get; set; }
    }
}
