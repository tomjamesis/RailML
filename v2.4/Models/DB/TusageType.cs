using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TusageType
    {
        public TusageType()
        {
            Tcategory = new HashSet<Tcategory>();
        }

        public byte TusageTypeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Tcategory> Tcategory { get; set; }
    }
}
