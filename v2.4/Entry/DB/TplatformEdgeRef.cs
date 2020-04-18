using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TplatformEdgeRef
    {
        public TplatformEdgeRef()
        {
            EstopDescription = new HashSet<EstopDescription>();
        }

        public short TplatformEdgeRefId { get; set; }

        public virtual ICollection<EstopDescription> EstopDescription { get; set; }
    }
}
