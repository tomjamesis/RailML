using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Eocp
    {
        public Eocp()
        {
            EoperationControlPoints = new HashSet<EoperationControlPoints>();
        }

        public short EocpId { get; set; }
        public short PropOperational { get; set; }
        public long PropService { get; set; }
        public long PropEquipment { get; set; }
        public short PropOther { get; set; }
        public long Tsi { get; set; }
        public long Area { get; set; }
        public long GeoCoord { get; set; }
        public long Designator { get; set; }

        public virtual TocpArea AreaNavigation { get; set; }
        public virtual Tdesignator DesignatorNavigation { get; set; }
        public virtual TgeoCoord GeoCoordNavigation { get; set; }
        public virtual EocpPropEquipment PropEquipmentNavigation { get; set; }
        public virtual EocpPropOperational PropOperationalNavigation { get; set; }
        public virtual EocpPropOther PropOtherNavigation { get; set; }
        public virtual TocpPropService PropServiceNavigation { get; set; }
        public virtual TocpTsi TsiNavigation { get; set; }
        public virtual ICollection<EoperationControlPoints> EoperationControlPoints { get; set; }
    }
}
