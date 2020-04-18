using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tequipment
    {
        public long TequipmentId { get; set; }
        public string Any { get; set; }
        public string Type { get; set; }
        public bool UsesValue { get; set; }
        public bool UsesValueSpecified { get; set; }
        public string Description { get; set; }
    }
}
