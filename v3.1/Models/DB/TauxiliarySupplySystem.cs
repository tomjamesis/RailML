using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TauxiliarySupplySystem
    {
        public TauxiliarySupplySystem()
        {
            EauxiliarySupply = new HashSet<EauxiliarySupply>();
        }

        public long TauxiliarySupplySystemId { get; set; }
        public decimal VoltageValue { get; set; }
        public bool VoltageValueSpecified { get; set; }
        public decimal FrequencyValue { get; set; }
        public bool FrequencyValueSpecified { get; set; }
        public decimal MaxPower { get; set; }

        public virtual ICollection<EauxiliarySupply> EauxiliarySupply { get; set; }
    }
}
