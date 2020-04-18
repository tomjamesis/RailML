using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tbridge
    {
        public short TbridgeId { get; set; }
        public string Kind { get; set; }
        public decimal MeterloadValue { get; set; }
        public bool MeterloadValueSpecified { get; set; }
    }
}
