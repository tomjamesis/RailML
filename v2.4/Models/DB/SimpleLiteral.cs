using System;
using System.Collections.Generic;

namespace Models.DB
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
