using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TdelimitedOrientedElement
    {
        public short TdelimitedOrientedElementId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TdelimitedDirection DirValueNavigation { get; set; }
    }
}
