using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TgeoCoord
    {
        public TgeoCoord()
        {
            Eocp = new HashSet<Eocp>();
            TbasePlacedElement = new HashSet<TbasePlacedElement>();
            Tlocation = new HashSet<Tlocation>();
            TmileageChange = new HashSet<TmileageChange>();
            TtrackNode = new HashSet<TtrackNode>();
        }

        public long TgeoCoordId { get; set; }
        public long Coord { get; set; }
        public long ExtraHeightValue { get; set; }
        public bool ExtraHeightValueSpecified { get; set; }
        public string EpsgCode { get; set; }
        public string HeightEpsgCode { get; set; }

        public virtual ICollection<Eocp> Eocp { get; set; }
        public virtual ICollection<TbasePlacedElement> TbasePlacedElement { get; set; }
        public virtual ICollection<Tlocation> Tlocation { get; set; }
        public virtual ICollection<TmileageChange> TmileageChange { get; set; }
        public virtual ICollection<TtrackNode> TtrackNode { get; set; }
    }
}
