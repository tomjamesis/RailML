using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TbaliseGroup
    {
        public TbaliseGroup()
        {
            Ebalises = new HashSet<Ebalises>();
        }

        public short TbaliseGroupId { get; set; }
        public short BaliseRef { get; set; }
        public string Type { get; set; }

        public virtual TbaliseRefInGroup BaliseRefNavigation { get; set; }
        public virtual ICollection<Ebalises> Ebalises { get; set; }
    }
}
