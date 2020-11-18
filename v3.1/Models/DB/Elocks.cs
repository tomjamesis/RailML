using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Elocks
    {
        public Elocks()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long ElocksId { get; set; }
        public short Lock { get; set; }

        public virtual Tlock LockNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
