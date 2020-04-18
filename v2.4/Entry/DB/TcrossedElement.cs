using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TcrossedElement
    {
        public TcrossedElement()
        {
            EcrossedElements = new HashSet<EcrossedElements>();
        }

        public short TcrossedElementId { get; set; }
        public string Type { get; set; }
        public decimal PosValue { get; set; }
        public bool PosValueSpecified { get; set; }

        public virtual ICollection<EcrossedElements> EcrossedElements { get; set; }
    }
}
