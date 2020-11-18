using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EblockParts
    {
        public EblockParts()
        {
            Erostering = new HashSet<Erostering>();
        }

        public long EblockPartsId { get; set; }
        public short BlockPart { get; set; }
        public string Any { get; set; }

        public virtual TblockPart BlockPartNavigation { get; set; }
        public virtual ICollection<Erostering> Erostering { get; set; }
    }
}
