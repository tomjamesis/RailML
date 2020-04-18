using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TlineClassification
    {
        public TlineClassification()
        {
            EloadLimit = new HashSet<EloadLimit>();
        }

        public long TlineClassificationId { get; set; }
        public string Name { get; set; }
        public decimal PayLoad { get; set; }

        public virtual ICollection<EloadLimit> EloadLimit { get; set; }
    }
}
