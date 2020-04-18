using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrackCircuitBorder
    {
        public TtrackCircuitBorder()
        {
            EtrainDetectionElements = new HashSet<EtrainDetectionElements>();
        }

        public short TtrackCircuitBorderId { get; set; }
        public byte InsulatedRailValue { get; set; }
        public bool InsulatedRailValueSpecified { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }

        public virtual TinsulatedRailSide InsulatedRailValueNavigation { get; set; }
        public virtual ICollection<EtrainDetectionElements> EtrainDetectionElements { get; set; }
    }
}
