using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tplaces
    {
        public Tplaces()
        {
            EpassengerFacility = new HashSet<EpassengerFacility>();
        }

        public long TplacesId { get; set; }
        public string Category { get; set; }
        public string TapTsiType9039Code { get; set; }
        public string Count { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EpassengerFacility> EpassengerFacility { get; set; }
    }
}
