using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Railml
    {
        public long RailmlId { get; set; }
        public short Metadata { get; set; }
        public short Infrastructure { get; set; }
        public long InfrastructureVisualizations { get; set; }
        public short Rollingstock { get; set; }
        public short Timetable { get; set; }
        public string Version { get; set; }

        public virtual Infrastructure InfrastructureNavigation { get; set; }
        public virtual InfrastructureVisualizations InfrastructureVisualizationsNavigation { get; set; }
        public virtual Tmetadata MetadataNavigation { get; set; }
        public virtual Rollingstock RollingstockNavigation { get; set; }
        public virtual Timetable TimetableNavigation { get; set; }
    }
}
