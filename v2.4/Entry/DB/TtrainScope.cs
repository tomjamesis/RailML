using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainScope
    {
        public TtrainScope()
        {
            Ttrain = new HashSet<Ttrain>();
            TuniqueTrainKey = new HashSet<TuniqueTrainKey>();
        }

        public byte TtrainScopeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Ttrain> Ttrain { get; set; }
        public virtual ICollection<TuniqueTrainKey> TuniqueTrainKey { get; set; }
    }
}
