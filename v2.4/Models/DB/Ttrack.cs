using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ttrack
    {
        public short TtrackId { get; set; }
        public long States { get; set; }
        public string Type { get; set; }
        public byte MainDirValue { get; set; }
        public bool MainDirValueSpecified { get; set; }
        public string InfraAttrGroupRef { get; set; }

        public virtual TextendedDirection MainDirValueNavigation { get; set; }
        public virtual TstatesWithLength StatesNavigation { get; set; }
    }
}
