using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TdelimitedDirection
    {
        public TdelimitedDirection()
        {
            TdelimitedOrientedElement = new HashSet<TdelimitedOrientedElement>();
            TdelimitedOrientedElementWithLength = new HashSet<TdelimitedOrientedElementWithLength>();
        }

        public byte TdelimitedDirectionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TdelimitedOrientedElement> TdelimitedOrientedElement { get; set; }
        public virtual ICollection<TdelimitedOrientedElementWithLength> TdelimitedOrientedElementWithLength { get; set; }
    }
}
