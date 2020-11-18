using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TelementRefInGroup
    {
        public TelementRefInGroup()
        {
            ElocallyControlledArea = new HashSet<ElocallyControlledArea>();
            EtrainGroup = new HashSet<EtrainGroup>();
            Tcontroller = new HashSet<Tcontroller>();
            ToperationControlPoint = new HashSet<ToperationControlPoint>();
        }

        public short TelementRefInGroupId { get; set; }
        public string Sequence { get; set; }

        public virtual ICollection<ElocallyControlledArea> ElocallyControlledArea { get; set; }
        public virtual ICollection<EtrainGroup> EtrainGroup { get; set; }
        public virtual ICollection<Tcontroller> Tcontroller { get; set; }
        public virtual ICollection<ToperationControlPoint> ToperationControlPoint { get; set; }
    }
}
