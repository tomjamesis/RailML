using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tcontroller
    {
        public Tcontroller()
        {
            Econtrollers = new HashSet<Econtrollers>();
        }

        public short TcontrollerId { get; set; }
        public long States { get; set; }
        public short OcpRef { get; set; }
        public string ParentControllerRef { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public byte TechnologyTypeValue { get; set; }
        public bool TechnologyTypeValueSpecified { get; set; }
        public string SwVersion { get; set; }

        public virtual TelementRefInGroup OcpRefNavigation { get; set; }
        public virtual Tstates StatesNavigation { get; set; }
        public virtual TcontrollerTechnologyType TechnologyTypeValueNavigation { get; set; }
        public virtual ICollection<Econtrollers> Econtrollers { get; set; }
    }
}
