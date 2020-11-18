using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EvehicleBrake
    {
        public EvehicleBrake()
        {
            EvehicleBrakes = new HashSet<EvehicleBrakes>();
        }

        public short EvehicleBrakeId { get; set; }
        public byte LoadSwitchValue { get; set; }
        public bool LoadSwitchValueSpecified { get; set; }
        public string AutoBrakePercentage { get; set; }
        public decimal MaxAutoBrakeMassValue { get; set; }
        public bool MaxAutoBrakeMassValueSpecified { get; set; }

        public virtual TloadSwitch LoadSwitchValueNavigation { get; set; }
        public virtual ICollection<EvehicleBrakes> EvehicleBrakes { get; set; }
    }
}
