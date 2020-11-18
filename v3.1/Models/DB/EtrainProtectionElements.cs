using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainProtectionElements
    {
        public EtrainProtectionElements()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EtrainProtectionElementsId { get; set; }
        public short TrainProtectionElement { get; set; }
        public short TrainProtectionElementGroup { get; set; }

        public virtual TtrainProtectionElementGroup TrainProtectionElementGroupNavigation { get; set; }
        public virtual TtrainProtectionElement TrainProtectionElementNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
