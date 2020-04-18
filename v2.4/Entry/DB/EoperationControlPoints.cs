using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EoperationControlPoints
    {
        public EoperationControlPoints()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EoperationControlPointsId { get; set; }
        public short Ocp { get; set; }

        public virtual Eocp OcpNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
