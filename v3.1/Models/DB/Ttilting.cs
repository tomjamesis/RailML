using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ttilting
    {
        public Ttilting()
        {
            Epassenger = new HashSet<Epassenger>();
            TspeedProfile = new HashSet<TspeedProfile>();
        }

        public long TtiltingId { get; set; }
        public decimal MaxTiltingAngleValue { get; set; }
        public bool MaxTiltingAngleValueSpecified { get; set; }
        public byte ActuationValue { get; set; }
        public bool ActuationValueSpecified { get; set; }
        public decimal TiltingSpeedValue { get; set; }
        public bool TiltingSpeedValueSpecified { get; set; }

        public virtual TtiltingActuationType ActuationValueNavigation { get; set; }
        public virtual ICollection<Epassenger> Epassenger { get; set; }
        public virtual ICollection<TspeedProfile> TspeedProfile { get; set; }
    }
}
