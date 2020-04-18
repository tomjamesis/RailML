using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Infrastructure
    {
        public Infrastructure()
        {
            Railml = new HashSet<Railml>();
        }

        public short InfrastructureId { get; set; }
        public long InfraAttrGroups { get; set; }
        public long Tracks { get; set; }
        public long TrackGroups { get; set; }
        public long OperationControlPoints { get; set; }
        public long Controllers { get; set; }
        public long SpeedProfiles { get; set; }
        public long States { get; set; }

        public virtual Econtrollers ControllersNavigation { get; set; }
        public virtual EinfraAttrGroup InfraAttrGroupsNavigation { get; set; }
        public virtual EoperationControlPoints OperationControlPointsNavigation { get; set; }
        public virtual EspeedProfiles SpeedProfilesNavigation { get; set; }
        public virtual Tstates StatesNavigation { get; set; }
        public virtual EtrackGroups TrackGroupsNavigation { get; set; }
        public virtual Etracks TracksNavigation { get; set; }
        public virtual ICollection<Railml> Railml { get; set; }
    }
}
