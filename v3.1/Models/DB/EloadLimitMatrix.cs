using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EloadLimitMatrix
    {
        public EloadLimitMatrix()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public short EloadLimitMatrixId { get; set; }
        public short LoadLimit { get; set; }

        public virtual EloadLimit LoadLimitNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
