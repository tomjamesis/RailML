using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EinfraAttrGroup
    {
        public EinfraAttrGroup()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EinfraAttrGroupId { get; set; }
        public short InfraAttributes { get; set; }

        public virtual EinfraAttr InfraAttributesNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
