using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TlocallyControlledArea
    {
        public short TlocallyControlledAreaId { get; set; }
        public long States { get; set; }
        public string OcpRef { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }

        public virtual Tstates StatesNavigation { get; set; }
    }
}
