using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EoperatingPeriodRef
    {
        public EoperatingPeriodRef()
        {
            EtrainPart = new HashSet<EtrainPart>();
        }

        public short EoperatingPeriodRefId { get; set; }
        public long SpecialService { get; set; }

        public virtual TspecialService SpecialServiceNavigation { get; set; }
        public virtual ICollection<EtrainPart> EtrainPart { get; set; }
    }
}
