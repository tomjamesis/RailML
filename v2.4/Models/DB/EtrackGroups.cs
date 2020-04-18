using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrackGroups
    {
        public EtrackGroups()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EtrackGroupsId { get; set; }
        public short Line { get; set; }
        public short LocallyControlledArea { get; set; }
        public string Any { get; set; }

        public virtual Eline LineNavigation { get; set; }
        public virtual ElocallyControlledArea LocallyControlledAreaNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
