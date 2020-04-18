using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tcontractor
    {
        public Tcontractor()
        {
            TorganizationalUnits = new HashSet<TorganizationalUnits>();
        }

        public short TcontractorId { get; set; }
        public string Role { get; set; }
        public string SubLevel { get; set; }

        public virtual ICollection<TorganizationalUnits> TorganizationalUnits { get; set; }
    }
}
