using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eclassification
    {
        public Eclassification()
        {
            Evehicle = new HashSet<Evehicle>();
        }

        public long EclassificationId { get; set; }
        public long Manufacturer { get; set; }
        public short Operator { get; set; }

        public virtual Tmanufacturer ManufacturerNavigation { get; set; }
        public virtual Eoperator OperatorNavigation { get; set; }
        public virtual ICollection<Evehicle> Evehicle { get; set; }
    }
}
