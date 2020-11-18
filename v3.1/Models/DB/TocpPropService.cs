using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TocpPropService
    {
        public TocpPropService()
        {
            Eocp = new HashSet<Eocp>();
        }

        public long TocpPropServiceId { get; set; }
        public bool Passenger { get; set; }
        public bool Service { get; set; }
        public bool Ship { get; set; }
        public bool Bus { get; set; }
        public bool Airport { get; set; }
        public bool Tariffpoint { get; set; }
        public bool GoodsLoading { get; set; }
        public bool GoodsSiding { get; set; }
        public bool GoodsIntermodal { get; set; }
        public bool GoodsMarshalling { get; set; }

        public virtual ICollection<Eocp> Eocp { get; set; }
    }
}
