using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tformation
    {
        public short TformationId { get; set; }
        public string FormationCount { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public decimal SpeedValue { get; set; }
        public bool SpeedValueSpecified { get; set; }
        public decimal WeightValue { get; set; }
        public bool WeightValueSpecified { get; set; }
        public decimal BruttoWeightValue { get; set; }
        public bool BruttoWeightValueSpecified { get; set; }
        public decimal NettoWeightValue { get; set; }
        public bool NettoWeightValueSpecified { get; set; }
        public decimal TareWeightValue { get; set; }
        public bool TareWeightValueSpecified { get; set; }
        public string EtcsTrainCategory { get; set; }
    }
}
