using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtractionInverter
    {
        public long TtractionInverterId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }
    }
}
