using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Ttunnel
    {
        public short TtunnelId { get; set; }
        public decimal CrossSectionValue { get; set; }
        public bool CrossSectionValueSpecified { get; set; }
        public string Kind { get; set; }
    }
}
