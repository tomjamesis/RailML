using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tblock
    {
        public short TblockId { get; set; }
        public string BlockGroupNumber { get; set; }
        public bool FixedValue { get; set; }
        public bool FixedValueSpecified { get; set; }
    }
}
