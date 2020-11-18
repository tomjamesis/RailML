using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TorientedElementWithLength
    {
        public short TorientedElementWithLengthId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TlaxDirection DirValueNavigation { get; set; }
    }
}
