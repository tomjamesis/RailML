using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrainGroup
    {
        public EtrainGroup()
        {
            EtrainGroups = new HashSet<EtrainGroups>();
        }

        public short EtrainGroupId { get; set; }
        public short TrainRef { get; set; }

        public virtual TelementRefInGroup TrainRefNavigation { get; set; }
        public virtual ICollection<EtrainGroups> EtrainGroups { get; set; }
    }
}
