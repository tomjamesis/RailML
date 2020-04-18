using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainDetector
    {
        public TtrainDetector()
        {
            EtrainDetectionElements = new HashSet<EtrainDetectionElements>();
        }

        public short TtrainDetectorId { get; set; }
        public string DetectionObject { get; set; }
        public string Medium { get; set; }
        public byte PosInTrackValue { get; set; }
        public bool PosInTrackValueSpecified { get; set; }
        public bool DirectionDetectionValue { get; set; }
        public bool DirectionDetectionValueSpecified { get; set; }
        public string Model { get; set; }
        public bool AxleCountingValue { get; set; }
        public bool AxleCountingValueSpecified { get; set; }
        public string OcpStationRef { get; set; }
        public string ControllerRef { get; set; }

        public virtual TposInTrack PosInTrackValueNavigation { get; set; }
        public virtual ICollection<EtrainDetectionElements> EtrainDetectionElements { get; set; }
    }
}
