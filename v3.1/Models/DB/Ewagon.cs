using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ewagon
    {
        public Ewagon()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public short EwagonId { get; set; }
        public short Passenger { get; set; }
        public short Goods { get; set; }
        public long AuxiliarySupplySystem { get; set; }
        public long DriversCab { get; set; }
        public long RackTraction { get; set; }
        public long Couplers { get; set; }
        public long TrainClearanceGauge { get; set; }

        public virtual TelectrificationSystem AuxiliarySupplySystemNavigation { get; set; }
        public virtual Ecouplers CouplersNavigation { get; set; }
        public virtual TdriversCabType DriversCabNavigation { get; set; }
        public virtual Egoods GoodsNavigation { get; set; }
        public virtual Epassenger PassengerNavigation { get; set; }
        public virtual TrackTractionType RackTractionNavigation { get; set; }
        public virtual TclearanceGaugeType TrainClearanceGaugeNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
