using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Econtrollers
    {
        public Econtrollers()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EcontrollersId { get; set; }
        public short Controller { get; set; }

        public virtual Tcontroller ControllerNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
