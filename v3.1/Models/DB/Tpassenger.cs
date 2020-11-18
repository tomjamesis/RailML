using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tpassenger
    {
        public short TpassengerId { get; set; }
        public byte DeckValue { get; set; }
        public bool DeckValueSpecified { get; set; }
        public bool DrivingCabValue { get; set; }
        public bool DrivingCabValueSpecified { get; set; }
        public bool TiltingValue { get; set; }
        public bool TiltingValueSpecified { get; set; }
        public bool AirTightnessValue { get; set; }
        public bool AirTightnessValueSpecified { get; set; }
        public bool EmergencyBrakeDeactivationValue { get; set; }
        public bool EmergencyBrakeDeactivationValueSpecified { get; set; }

        public virtual TverbalCounter DeckValueNavigation { get; set; }
    }
}
