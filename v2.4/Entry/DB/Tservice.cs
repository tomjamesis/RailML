using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tservice
    {
        public Tservice()
        {
            Egoods = new HashSet<Egoods>();
            EpassengerFacility = new HashSet<EpassengerFacility>();
            EpassengerFacilityTt = new HashSet<EpassengerFacilityTt>();
        }

        public long TserviceId { get; set; }
        public string Name { get; set; }
        public string TapTsiType7161Code { get; set; }
        public string Count { get; set; }
        public string Description { get; set; }
        public decimal ValueValue { get; set; }
        public bool ValueValueSpecified { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Egoods> Egoods { get; set; }
        public virtual ICollection<EpassengerFacility> EpassengerFacility { get; set; }
        public virtual ICollection<EpassengerFacilityTt> EpassengerFacilityTt { get; set; }
    }
}
