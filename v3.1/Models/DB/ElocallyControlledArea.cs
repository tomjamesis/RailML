using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class ElocallyControlledArea
    {
        public ElocallyControlledArea()
        {
            EtrackGroups = new HashSet<EtrackGroups>();
        }

        public short ElocallyControlledAreaId { get; set; }
        public short TrackRef { get; set; }
        public short ControllerRef { get; set; }

        public virtual TelementRefInGroup ControllerRefNavigation { get; set; }
        public virtual TtrackRefInGroup TrackRefNavigation { get; set; }
        public virtual ICollection<EtrackGroups> EtrackGroups { get; set; }
    }
}
