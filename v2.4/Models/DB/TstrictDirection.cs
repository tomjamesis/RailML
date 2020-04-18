using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstrictDirection
    {
        public TstrictDirection()
        {
            TmileageChange = new HashSet<TmileageChange>();
            TstrictOrientedElement = new HashSet<TstrictOrientedElement>();
            TstrictOrientedElementWithLength = new HashSet<TstrictOrientedElementWithLength>();
            TtrackRef = new HashSet<TtrackRef>();
        }

        public byte TstrictDirectionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TmileageChange> TmileageChange { get; set; }
        public virtual ICollection<TstrictOrientedElement> TstrictOrientedElement { get; set; }
        public virtual ICollection<TstrictOrientedElementWithLength> TstrictOrientedElementWithLength { get; set; }
        public virtual ICollection<TtrackRef> TtrackRef { get; set; }
    }
}
