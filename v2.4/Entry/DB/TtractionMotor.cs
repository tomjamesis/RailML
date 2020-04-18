using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtractionMotor
    {
        public long TtractionMotorId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal NominalPowerValue { get; set; }
        public bool NominalPowerValueSpecified { get; set; }
        public decimal NominalVoltageValue { get; set; }
        public bool NominalVoltageValueSpecified { get; set; }
        public decimal NominalCurrentValue { get; set; }
        public bool NominalCurrentValueSpecified { get; set; }
        public decimal NominalFrequencyValue { get; set; }
        public bool NominalFrequencyValueSpecified { get; set; }
        public decimal NominalFluxValue { get; set; }
        public bool NominalFluxValueSpecified { get; set; }
        public decimal NominalPhiValue { get; set; }
        public bool NominalPhiValueSpecified { get; set; }
        public string NumberPolePairs { get; set; }
        public decimal StatorResistanceValue { get; set; }
        public bool StatorResistanceValueSpecified { get; set; }
        public decimal RotorResistanceValue { get; set; }
        public bool RotorResistanceValueSpecified { get; set; }
        public decimal FerrumResistanceValue { get; set; }
        public bool FerrumResistanceValueSpecified { get; set; }
        public decimal AdditionalResistanceValue { get; set; }
        public bool AdditionalResistanceValueSpecified { get; set; }
        public decimal MainInductanceValue { get; set; }
        public bool MainInductanceValueSpecified { get; set; }
        public decimal StatorLeakageInductanceValue { get; set; }
        public bool StatorLeakageInductanceValueSpecified { get; set; }
        public decimal RotorLeakageInductanceValue { get; set; }
        public bool RotorLeakageInductanceValueSpecified { get; set; }
        public string NominalRevolutions { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }
    }
}
