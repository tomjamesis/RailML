using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrackRef
    {
        public TtrackRef()
        {
            EsectionTt = new HashSet<EsectionTt>();
        }

        public short TtrackRefId { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TstrictDirection DirValueNavigation { get; set; }
        public virtual ICollection<EsectionTt> EsectionTt { get; set; }
    }
}
