using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eattributes
    {
        public Eattributes()
        {
            EgeneralInfraAttribute = new HashSet<EgeneralInfraAttribute>();
        }

        public long EattributesId { get; set; }
        public long Attribute { get; set; }

        public virtual Tattribute AttributeNavigation { get; set; }
        public virtual ICollection<EgeneralInfraAttribute> EgeneralInfraAttribute { get; set; }
    }
}
