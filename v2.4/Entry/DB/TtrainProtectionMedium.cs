using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainProtectionMedium
    {
        public TtrainProtectionMedium()
        {
            TnationalSystem = new HashSet<TnationalSystem>();
            TtrainProtection = new HashSet<TtrainProtection>();
            TtrainProtectionChange = new HashSet<TtrainProtectionChange>();
            TtrainProtectionElement = new HashSet<TtrainProtectionElement>();
        }

        public byte TtrainProtectionMediumId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<TnationalSystem> TnationalSystem { get; set; }
        public virtual ICollection<TtrainProtection> TtrainProtection { get; set; }
        public virtual ICollection<TtrainProtectionChange> TtrainProtectionChange { get; set; }
        public virtual ICollection<TtrainProtectionElement> TtrainProtectionElement { get; set; }
    }
}
