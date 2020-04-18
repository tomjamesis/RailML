using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TorientedElement
    {
        public short TorientedElementId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TlaxDirection DirValueNavigation { get; set; }
    }
}
