using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TspecificTransmissionModule
    {
        public TspecificTransmissionModule()
        {
            Eetcs = new HashSet<Eetcs>();
        }

        public short TspecificTransmissionModuleId { get; set; }
        public string OnBoardUnitId { get; set; }
        public string SoftwareVersion { get; set; }
        public string NationalSystemRef { get; set; }

        public virtual ICollection<Eetcs> Eetcs { get; set; }
    }
}
