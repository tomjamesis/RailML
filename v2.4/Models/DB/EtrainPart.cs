using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainPart
    {
        public EtrainPart()
        {
            EtrainParts = new HashSet<EtrainParts>();
        }

        public short EtrainPartId { get; set; }
        public short FormationTt { get; set; }
        public short OperatingPeriodRef { get; set; }
        public long OcpsTt { get; set; }
        public long OrganizationalUnitBinding { get; set; }
        public short AnnotationRef { get; set; }
        public string Any { get; set; }

        public virtual TannotationRef AnnotationRefNavigation { get; set; }
        public virtual EformationTt FormationTtNavigation { get; set; }
        public virtual EocpsTt OcpsTtNavigation { get; set; }
        public virtual EoperatingPeriodRef OperatingPeriodRefNavigation { get; set; }
        public virtual EorganizationalUnitBinding OrganizationalUnitBindingNavigation { get; set; }
        public virtual ICollection<EtrainParts> EtrainParts { get; set; }
    }
}
