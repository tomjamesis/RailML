using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tmanufacturer
    {
        public Tmanufacturer()
        {
            Eclassification = new HashSet<Eclassification>();
        }

        public long TmanufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string VehicleManufacturerRef { get; set; }
        public string ManufacturerType { get; set; }
        public string SerialNumber { get; set; }

        public virtual ICollection<Eclassification> Eclassification { get; set; }
    }
}
