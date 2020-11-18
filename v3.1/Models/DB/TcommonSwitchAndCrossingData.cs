using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TcommonSwitchAndCrossingData
    {
        public short TcommonSwitchAndCrossingDataId { get; set; }
        public string TrackContinueCourse { get; set; }
        public decimal TrackContinueRadiusValue { get; set; }
        public bool TrackContinueRadiusValueSpecified { get; set; }
        public string NormalPosition { get; set; }
        public string Model { get; set; }
        public decimal LengthValue { get; set; }
        public bool LengthValueSpecified { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }
    }
}
