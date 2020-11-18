using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tstorage
    {
        public short TstorageId { get; set; }
        public decimal MaximumCurrentCharging { get; set; }
        public decimal MaximumCurrentDischarging { get; set; }
        public decimal MaximumPowerCharging { get; set; }
        public decimal MaximumPowerDischarging { get; set; }
        public decimal MaximumChargingEnergy { get; set; }
        public decimal ChargingEfficiencyValue { get; set; }
        public bool ChargingEfficiencyValueSpecified { get; set; }
        public decimal DischargingEfficiencyValue { get; set; }
        public bool DischargingEfficiencyValueSpecified { get; set; }
        public decimal MeanStorageEfficiencyValue { get; set; }
        public bool MeanStorageEfficiencyValueSpecified { get; set; }
    }
}
