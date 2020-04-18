using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TserviceSectionRef
    {
        public TserviceSectionRef()
        {
            EstopDescription = new HashSet<EstopDescription>();
        }

        public short TserviceSectionRefId { get; set; }

        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
    }
}
