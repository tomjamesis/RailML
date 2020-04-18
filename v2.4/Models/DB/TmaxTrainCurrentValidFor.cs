using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TmaxTrainCurrentValidFor
    {
        public TmaxTrainCurrentValidFor()
        {
            TmaxTrainCurrent = new HashSet<TmaxTrainCurrent>();
        }

        public byte TmaxTrainCurrentValidForId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TmaxTrainCurrent> TmaxTrainCurrent { get; set; }
    }
}
