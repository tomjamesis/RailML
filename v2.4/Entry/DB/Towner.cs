using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Towner
    {
        public Towner()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long TownerId { get; set; }
        public string OwnerName { get; set; }
        public string UicNo { get; set; }
        public string InfrastructureManagerRef { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
