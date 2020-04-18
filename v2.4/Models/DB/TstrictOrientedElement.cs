using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstrictOrientedElement
    {
        public short TstrictOrientedElementId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TstrictDirection DirValueNavigation { get; set; }
    }
}
