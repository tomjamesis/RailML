using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class SimpleLiteral
    {
        public SimpleLiteral()
        {
            ElementContainer = new HashSet<ElementContainer>();
        }

        public long SimpleLiteralId { get; set; }

        public virtual ICollection<ElementContainer> ElementContainer { get; set; }
    }
}
