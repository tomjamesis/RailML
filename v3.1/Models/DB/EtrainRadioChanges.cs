using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EtrainRadioChanges
    {
        public EtrainRadioChanges()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EtrainRadioChangesId { get; set; }
        public short TrainRadioChange { get; set; }

        public virtual TtrainRadioChange TrainRadioChangeNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
