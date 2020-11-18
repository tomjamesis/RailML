using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TdieselEngine
    {
        public TdieselEngine()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public long TdieselEngineId { get; set; }
        public string Count { get; set; }
        public string AssemblyName { get; set; }
        public decimal NominalPowerValue { get; set; }
        public bool NominalPowerValueSpecified { get; set; }
        public decimal AvailableAuxiliaryPowerValue { get; set; }
        public bool AvailableAuxiliaryPowerValueSpecified { get; set; }
        public decimal FuelCapacityValue { get; set; }
        public bool FuelCapacityValueSpecified { get; set; }
        public decimal MeanEfficiencyValue { get; set; }
        public bool MeanEfficiencyValueSpecified { get; set; }

        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
