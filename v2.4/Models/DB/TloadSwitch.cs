using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TloadSwitch
    {
        public TloadSwitch()
        {
            EvehicleBrake = new HashSet<EvehicleBrake>();
        }

        public byte TloadSwitchId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<EvehicleBrake> EvehicleBrake { get; set; }
    }
}
