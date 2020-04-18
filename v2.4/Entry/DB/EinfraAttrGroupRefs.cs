using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EinfraAttrGroupRefs
    {
        public EinfraAttrGroupRefs()
        {
            Etrack = new HashSet<Etrack>();
        }

        public long EinfraAttrGroupRefsId { get; set; }
        public long InfraAttrGroupRef { get; set; }

        public virtual TelementWithReference InfraAttrGroupRefNavigation { get; set; }
        public virtual ICollection<Etrack> Etrack { get; set; }
    }
}
