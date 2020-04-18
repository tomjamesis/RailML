using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EgeneralInfraAttributes
    {
        public EgeneralInfraAttributes()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long EgeneralInfraAttributesId { get; set; }
        public long GeneralInfraAttribute { get; set; }

        public virtual EgeneralInfraAttribute GeneralInfraAttributeNavigation { get; set; }
        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
