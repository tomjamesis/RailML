using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tgear
    {
        public long TgearId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal GearRatioValue { get; set; }
        public bool GearRatioValueSpecified { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }
        public string DesignType { get; set; }
        public string ManufacturerName { get; set; }
        public decimal NominalPowerValue { get; set; }
        public bool NominalPowerValueSpecified { get; set; }
        public string TorqueConversion { get; set; }
    }
}
