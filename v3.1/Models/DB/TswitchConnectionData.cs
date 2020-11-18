using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TswitchConnectionData
    {
        public TswitchConnectionData()
        {
            Ecrossing = new HashSet<Ecrossing>();
            Eswitch = new HashSet<Eswitch>();
        }

        public short TswitchConnectionDataId { get; set; }
        public string Course { get; set; }
        public decimal RadiusValue { get; set; }
        public bool RadiusValueSpecified { get; set; }
        public decimal MaxSpeedValue { get; set; }
        public bool MaxSpeedValueSpecified { get; set; }
        public decimal BranchDistValue { get; set; }
        public bool BranchDistValueSpecified { get; set; }
        public string Orientation { get; set; }
        public bool Passable { get; set; }

        public virtual ICollection<Ecrossing> Ecrossing { get; set; }
        public virtual ICollection<Eswitch> Eswitch { get; set; }
    }
}
