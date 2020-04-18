using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtrainDetectionElements
    {
        public EtrainDetectionElements()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EtrainDetectionElementsId { get; set; }
        public short TrainDetector { get; set; }
        public short TrackCircuitBorder { get; set; }

        public virtual TtrackCircuitBorder TrackCircuitBorderNavigation { get; set; }
        public virtual TtrainDetector TrainDetectorNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
