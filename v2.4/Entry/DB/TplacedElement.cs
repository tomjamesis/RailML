using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TplacedElement
    {
        public TplacedElement()
        {
            EgeoMappings = new HashSet<EgeoMappings>();
        }

        public short TplacedElementId { get; set; }
        public long States { get; set; }

        public virtual Tstates StatesNavigation { get; set; }
        public virtual ICollection<EgeoMappings> EgeoMappings { get; set; }
    }
}
