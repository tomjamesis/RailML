using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TownerChange
    {
        public TownerChange()
        {
            EownerChanges = new HashSet<EownerChanges>();
        }

        public short TownerChangeId { get; set; }
        public string OwnerName { get; set; }
        public string UicNo { get; set; }
        public string InfrastructureManagerRef { get; set; }

        public virtual ICollection<EownerChanges> EownerChanges { get; set; }
    }
}
