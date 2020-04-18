using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TvalidForMovements
    {
        public TvalidForMovements()
        {
            TstopPost = new HashSet<TstopPost>();
        }

        public long TvalidForMovementsId { get; set; }
        public string Kind { get; set; }

        public virtual ICollection<TstopPost> TstopPost { get; set; }
    }
}
