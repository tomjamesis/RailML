using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TmaxTrainCurrentType
    {
        public TmaxTrainCurrentType()
        {
            TmaxTrainCurrent = new HashSet<TmaxTrainCurrent>();
        }

        public byte TmaxTrainCurrentTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TmaxTrainCurrent> TmaxTrainCurrent { get; set; }
    }
}
