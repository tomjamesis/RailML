using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TuniqueTrainKey
    {
        public TuniqueTrainKey()
        {
            EreplacementOf = new HashSet<EreplacementOf>();
        }

        public long TuniqueTrainKeyId { get; set; }
        public string TrainNumber { get; set; }
        public string AdditionalTrainNumber { get; set; }
        public byte ScopeValue { get; set; }
        public bool ScopeValueSpecified { get; set; }

        public virtual TtrainScope ScopeValueNavigation { get; set; }
        public virtual ICollection<EreplacementOf> EreplacementOf { get; set; }
    }
}
