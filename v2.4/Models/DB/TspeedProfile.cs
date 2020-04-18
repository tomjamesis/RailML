using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspeedProfile
    {
        public TspeedProfile()
        {
            EspeedProfiles = new HashSet<EspeedProfiles>();
        }

        public short TspeedProfileId { get; set; }
        public long Tilting { get; set; }
        public long Braking { get; set; }
        public long Path { get; set; }
        public string Influence { get; set; }
        public decimal MaxAxleLoadValue { get; set; }
        public bool MaxAxleLoadValueSpecified { get; set; }
        public decimal MaxMeterLoadValue { get; set; }
        public bool MaxMeterLoadValueSpecified { get; set; }
        public string OperatingPeriodRef { get; set; }
        public DateTime StartTimeValue { get; set; }
        public bool StartTimeValueSpecified { get; set; }
        public DateTime EndTimeValue { get; set; }
        public bool EndTimeValueSpecified { get; set; }
        public string EndDayOffset { get; set; }
        public string TrainProtectionSystem { get; set; }
        public string VerbalConstraint { get; set; }

        public virtual Tbraking BrakingNavigation { get; set; }
        public virtual Tpath PathNavigation { get; set; }
        public virtual Ttilting TiltingNavigation { get; set; }
        public virtual ICollection<EspeedProfiles> EspeedProfiles { get; set; }
    }
}
