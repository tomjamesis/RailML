using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ederailers
    {
        public Ederailers()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EderailersId { get; set; }
        public short Derailer { get; set; }

        public virtual Tderailer DerailerNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
