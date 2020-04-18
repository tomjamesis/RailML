using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EstopDescription
    {
        public EstopDescription()
        {
            EocpTt = new HashSet<EocpTt>();
        }

        public short EstopDescriptionId { get; set; }
        public long StopTimes { get; set; }
        public long StopActivities { get; set; }
        public short PlatformEdgeRef { get; set; }
        public short ServiceSectionRef { get; set; }
        public long TrackInfo { get; set; }
        public short AnnotationRef { get; set; }

        public virtual TannotationRef AnnotationRefNavigation { get; set; }
        public virtual TplatformEdgeRef PlatformEdgeRefNavigation { get; set; }
        public virtual TserviceSectionRef ServiceSectionRefNavigation { get; set; }
        public virtual EstopActivities StopActivitiesNavigation { get; set; }
        public virtual TstopTimes StopTimesNavigation { get; set; }
        public virtual TstationTrackInfo TrackInfoNavigation { get; set; }
        public virtual ICollection<EocpTt> EocpTt { get; set; }
    }
}
