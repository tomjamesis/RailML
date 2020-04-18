using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperationControlPoint
    {
        public short ToperationControlPointId { get; set; }
        public short ControllerRef { get; set; }
        public string Number { get; set; }
        public string Abbrevation { get; set; }
        public string Timezone { get; set; }
        public string ParentOcpRef { get; set; }

        public virtual TelementRefInGroup ControllerRefNavigation { get; set; }
    }
}
