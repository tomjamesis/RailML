using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspeedProfileRefRs
    {
        public TspeedProfileRefRs()
        {
            Eformation = new HashSet<Eformation>();
        }

        public long TspeedProfileRefRsid { get; set; }
        public string Ref { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
