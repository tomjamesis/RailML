using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Edoors
    {
        public Edoors()
        {
            Epassenger = new HashSet<Epassenger>();
        }

        public short EdoorsId { get; set; }
        public long PassengerFlowSpeed { get; set; }

        public virtual TpassengerFlowSpeed PassengerFlowSpeedNavigation { get; set; }
        public virtual ICollection<Epassenger> Epassenger { get; set; }
    }
}
