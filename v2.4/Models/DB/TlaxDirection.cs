using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TlaxDirection
    {
        public TlaxDirection()
        {
            TcrossSection = new HashSet<TcrossSection>();
            TorientedElement = new HashSet<TorientedElement>();
            TorientedElementWithLength = new HashSet<TorientedElementWithLength>();
        }

        public byte TlaxDirectionId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TcrossSection> TcrossSection { get; set; }
        public virtual ICollection<TorientedElement> TorientedElement { get; set; }
        public virtual ICollection<TorientedElementWithLength> TorientedElementWithLength { get; set; }
    }
}
