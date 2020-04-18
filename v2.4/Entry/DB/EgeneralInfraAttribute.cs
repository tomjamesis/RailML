using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EgeneralInfraAttribute
    {
        public EgeneralInfraAttribute()
        {
            EgeneralInfraAttributes = new HashSet<EgeneralInfraAttributes>();
        }

        public long EgeneralInfraAttributeId { get; set; }
        public long Attributes { get; set; }
        public string Any { get; set; }

        public virtual Eattributes AttributesNavigation { get; set; }
        public virtual ICollection<EgeneralInfraAttributes> EgeneralInfraAttributes { get; set; }
    }
}
