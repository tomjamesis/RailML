using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TrailNetwork
    {
        public TrailNetwork()
        {
            EloadLimit = new HashSet<EloadLimit>();
        }

        public long TrailNetworkId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EloadLimit> EloadLimit { get; set; }
    }
}
