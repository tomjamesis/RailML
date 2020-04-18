using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainProtectionElement
    {
        public TtrainProtectionElement()
        {
            EtrainProtectionElements = new HashSet<EtrainProtectionElements>();
        }

        public short TtrainProtectionElementId { get; set; }
        public byte MediumValue { get; set; }
        public bool MediumValueSpecified { get; set; }
        public string System { get; set; }
        public string TrainProtectionSystem { get; set; }
        public string Model { get; set; }

        public virtual TtrainProtectionMedium MediumValueNavigation { get; set; }
        public virtual ICollection<EtrainProtectionElements> EtrainProtectionElements { get; set; }
    }
}
