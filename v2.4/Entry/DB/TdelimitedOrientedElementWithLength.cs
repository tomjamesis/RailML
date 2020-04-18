using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TdelimitedOrientedElementWithLength
    {
        public short TdelimitedOrientedElementWithLengthId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TdelimitedDirection DirValueNavigation { get; set; }
    }
}
