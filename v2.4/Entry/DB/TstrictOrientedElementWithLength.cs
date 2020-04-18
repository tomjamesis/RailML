using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TstrictOrientedElementWithLength
    {
        public short TstrictOrientedElementWithLengthId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TstrictDirection DirValueNavigation { get; set; }
    }
}
