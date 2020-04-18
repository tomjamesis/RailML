using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrackCondition
    {
        public TtrackCondition()
        {
            EtrackConditions = new HashSet<EtrackConditions>();
        }

        public short TtrackConditionId { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public string Type { get; set; }

        public virtual ICollection<EtrackConditions> EtrackConditions { get; set; }
    }
}
