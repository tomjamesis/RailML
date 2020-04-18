using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TeddyCurrentBrake
    {
        public TeddyCurrentBrake()
        {
            EvehicleBrakes = new HashSet<EvehicleBrakes>();
        }

        public long TeddyCurrentBrakeId { get; set; }
        public decimal MaxPower { get; set; }
        public decimal MaxEffort { get; set; }
        public decimal MinSpeed { get; set; }

        public virtual ICollection<EvehicleBrakes> EvehicleBrakes { get; set; }
    }
}
