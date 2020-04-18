using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperationModeChange
    {
        public ToperationModeChange()
        {
            EoperationModeChanges = new HashSet<EoperationModeChanges>();
        }

        public short ToperationModeChangeId { get; set; }
        public string ModeLegislative { get; set; }
        public string ModeExecutive { get; set; }
        public string ClearanceManaging { get; set; }

        public virtual ICollection<EoperationModeChanges> EoperationModeChanges { get; set; }
    }
}
