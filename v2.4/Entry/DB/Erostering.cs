using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Erostering
    {
        public Erostering()
        {
            Erosterings = new HashSet<Erosterings>();
        }

        public short ErosteringId { get; set; }
        public long BlockParts { get; set; }
        public long Blocks { get; set; }
        public long Circulations { get; set; }

        public virtual EblockParts BlockPartsNavigation { get; set; }
        public virtual Eblocks BlocksNavigation { get; set; }
        public virtual Ecirculations CirculationsNavigation { get; set; }
        public virtual ICollection<Erosterings> Erosterings { get; set; }
    }
}
