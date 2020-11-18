using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TmileageChange
    {
        public TmileageChange()
        {
            EmileageChanges = new HashSet<EmileageChanges>();
        }

        public short TmileageChangeId { get; set; }
        public long GeoCoord { get; set; }
        public decimal AbsPosIn { get; set; }
        public decimal AbsPosInOffsetValue { get; set; }
        public bool AbsPosInOffsetValueSpecified { get; set; }
        public short Type { get; set; }
        public decimal AbsPos { get; set; }
        public decimal Pos { get; set; }
        public byte AbsDirValue { get; set; }
        public bool AbsDirValueSpecified { get; set; }
        public byte DirValue { get; set; }
        public bool DirValueSpecified { get; set; }

        public virtual TmileageDirection AbsDirValueNavigation { get; set; }
        public virtual TstrictDirection DirValueNavigation { get; set; }
        public virtual TgeoCoord GeoCoordNavigation { get; set; }
        public virtual Type TypeNavigation { get; set; }
        public virtual ICollection<EmileageChanges> EmileageChanges { get; set; }
    }
}
