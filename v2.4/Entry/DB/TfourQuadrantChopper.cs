using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TfourQuadrantChopper
    {
        public long TfourQuadrantChopperId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal MeanPhiValue { get; set; }
        public bool MeanPhiValueSpecified { get; set; }
        public decimal MeanPhiRegenerationValue { get; set; }
        public bool MeanPhiRegenerationValueSpecified { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }
    }
}
