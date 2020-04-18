using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainProtectionElementGroup
    {
        public TtrainProtectionElementGroup()
        {
            EtrainProtectionElements = new HashSet<EtrainProtectionElements>();
        }

        public short TtrainProtectionElementGroupId { get; set; }
        public long TrainProtectionElementRef { get; set; }

        public virtual TelementWithReference TrainProtectionElementRefNavigation { get; set; }
        public virtual ICollection<EtrainProtectionElements> EtrainProtectionElements { get; set; }
    }
}
