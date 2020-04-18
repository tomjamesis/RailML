using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TcontrollerTechnologyType
    {
        public TcontrollerTechnologyType()
        {
            Tcontroller = new HashSet<Tcontroller>();
        }

        public byte TcontrollerTechnologyTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tcontroller> Tcontroller { get; set; }
    }
}
