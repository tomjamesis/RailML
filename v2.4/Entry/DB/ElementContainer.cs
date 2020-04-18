using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ElementContainer
    {
        public ElementContainer()
        {
            TglobalElementWithMetadata = new HashSet<TglobalElementWithMetadata>();
        }

        public long ElementContainerId { get; set; }
        public long Any { get; set; }

        public virtual SimpleLiteral AnyNavigation { get; set; }
        public virtual ICollection<TglobalElementWithMetadata> TglobalElementWithMetadata { get; set; }
    }
}
