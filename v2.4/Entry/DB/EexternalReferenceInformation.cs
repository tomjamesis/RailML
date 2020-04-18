using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EexternalReferenceInformation
    {
        public EexternalReferenceInformation()
        {
            EexternalReference = new HashSet<EexternalReference>();
        }

        public long EexternalReferenceInformationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EexternalReference> EexternalReference { get; set; }
    }
}
