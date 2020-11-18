using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TlevelCrossing
    {
        public short TlevelCrossingId { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public decimal AngleValue { get; set; }
        public bool AngleValueSpecified { get; set; }
        public string Protection { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }
    }
}
