using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EsignalGroups
    {
        public EsignalGroups()
        {
            Esignals = new HashSet<Esignals>();
        }

        public long EsignalGroupsId { get; set; }
        public short SignalGroup { get; set; }

        public virtual EsignalGroup SignalGroupNavigation { get; set; }
        public virtual ICollection<Esignals> Esignals { get; set; }
    }
}
