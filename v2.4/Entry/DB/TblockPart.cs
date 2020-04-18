using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TblockPart
    {
        public TblockPart()
        {
            EblockParts = new HashSet<EblockParts>();
        }

        public short TblockPartId { get; set; }
        public DateTime BeginValue { get; set; }
        public bool BeginValueSpecified { get; set; }
        public string BeginDay { get; set; }
        public DateTime EndValue { get; set; }
        public bool EndValueSpecified { get; set; }
        public string EndDay { get; set; }
        public string StartOcpRef { get; set; }
        public string EndOcpRef { get; set; }
        public string TrainPartRef { get; set; }
        public string OperatingPeriodRef { get; set; }
        public string Mission { get; set; }
        public bool FixedValue { get; set; }
        public bool FixedValueSpecified { get; set; }
        public decimal RunLengthValue { get; set; }
        public bool RunLengthValueSpecified { get; set; }
        public string VehicleRef { get; set; }
        public string FormationRef { get; set; }

        public virtual ICollection<EblockParts> EblockParts { get; set; }
    }
}
