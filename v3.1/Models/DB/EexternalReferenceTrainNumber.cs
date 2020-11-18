using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EexternalReferenceTrainNumber
    {
        public EexternalReferenceTrainNumber()
        {
            EexternalReference = new HashSet<EexternalReference>();
        }

        public long EexternalReferenceTrainNumberId { get; set; }
        public long OrganizationalUnitBinding { get; set; }
        public string TrainNumber { get; set; }

        public virtual EorganizationalUnitBinding OrganizationalUnitBindingNavigation { get; set; }
        public virtual ICollection<EexternalReference> EexternalReference { get; set; }
    }
}
