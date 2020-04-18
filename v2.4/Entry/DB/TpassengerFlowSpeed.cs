using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TpassengerFlowSpeed
    {
        public TpassengerFlowSpeed()
        {
            Edoors = new HashSet<Edoors>();
        }

        public long TpassengerFlowSpeedId { get; set; }
        public decimal FlowSpeedValue { get; set; }
        public bool FlowSpeedValueSpecified { get; set; }
        public decimal PlatformHeightValue { get; set; }
        public bool PlatformHeightValueSpecified { get; set; }

        public virtual ICollection<Edoors> Edoors { get; set; }
    }
}
