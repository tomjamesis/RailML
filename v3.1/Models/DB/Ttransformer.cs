using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ttransformer
    {
        public long TtransformerId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal FerrumResistanceValue { get; set; }
        public bool FerrumResistanceValueSpecified { get; set; }
        public decimal AdditionalResistanceValue { get; set; }
        public bool AdditionalResistanceValueSpecified { get; set; }
        public decimal MainInductanceValue { get; set; }
        public bool MainInductanceValueSpecified { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }
    }
}
