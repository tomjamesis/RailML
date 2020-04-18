using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tline
    {
        public short TlineId { get; set; }
        public long States { get; set; }
        public string Type { get; set; }
        public string InfrastructureManagerRef { get; set; }
        public string LineCategory { get; set; }

        public virtual Tstates StatesNavigation { get; set; }
    }
}
