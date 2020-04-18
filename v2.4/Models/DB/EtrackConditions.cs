using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackConditions
    {
        public EtrackConditions()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EtrackConditionsId { get; set; }
        public short TrackCondition { get; set; }

        public virtual TtrackCondition TrackConditionNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
