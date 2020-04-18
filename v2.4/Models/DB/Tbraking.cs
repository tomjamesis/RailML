using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tbraking
    {
        public Tbraking()
        {
            TspeedProfile = new HashSet<TspeedProfile>();
        }

        public long TbrakingId { get; set; }
        public string BrakeType { get; set; }
        public byte AirBrakeApplicationPositionValue { get; set; }
        public bool AirBrakeApplicationPositionValueSpecified { get; set; }
        public string MinimumBrakePercentage { get; set; }

        public virtual TairBrakeApplicationPosition AirBrakeApplicationPositionValueNavigation { get; set; }
        public virtual ICollection<TspeedProfile> TspeedProfile { get; set; }
    }
}
