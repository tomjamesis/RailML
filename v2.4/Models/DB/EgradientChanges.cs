using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EgradientChanges
    {
        public EgradientChanges()
        {
            EtrackElements = new HashSet<EtrackElements>();
        }

        public long EgradientChangesId { get; set; }
        public short GradientChange { get; set; }

        public virtual TgradientChange GradientChangeNavigation { get; set; }
        public virtual ICollection<EtrackElements> EtrackElements { get; set; }
    }
}
