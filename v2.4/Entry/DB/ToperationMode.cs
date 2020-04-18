using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class ToperationMode
    {
        public ToperationMode()
        {
            EinfraAttr = new HashSet<EinfraAttr>();
        }

        public long ToperationModeId { get; set; }
        public string ModeLegislative { get; set; }
        public string ModeExecutive { get; set; }
        public string ClearanceManaging { get; set; }

        public virtual ICollection<EinfraAttr> EinfraAttr { get; set; }
    }
}
