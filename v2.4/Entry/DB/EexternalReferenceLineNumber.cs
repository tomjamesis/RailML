using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EexternalReferenceLineNumber
    {
        public EexternalReferenceLineNumber()
        {
            EexternalReference = new HashSet<EexternalReference>();
        }

        public long EexternalReferenceLineNumberId { get; set; }
        public string LineNumber { get; set; }

        public virtual ICollection<EexternalReference> EexternalReference { get; set; }
    }
}
