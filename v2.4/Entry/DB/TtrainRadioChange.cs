using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TtrainRadioChange
    {
        public TtrainRadioChange()
        {
            EtrainRadioChanges = new HashSet<EtrainRadioChanges>();
        }

        public short TtrainRadioChangeId { get; set; }
        public string RadioSystem { get; set; }
        public string NetworkSelection { get; set; }
        public bool PublicEmergencyValue { get; set; }
        public bool PublicEmergencyValueSpecified { get; set; }
        public bool BroadcastCallsValue { get; set; }
        public bool BroadcastCallsValueSpecified { get; set; }
        public bool TextMessageServiceValue { get; set; }
        public bool TextMessageServiceValueSpecified { get; set; }
        public bool DirectModeValue { get; set; }
        public bool DirectModeValueSpecified { get; set; }
        public bool PublicNetworkRoamingValue { get; set; }
        public bool PublicNetworkRoamingValueSpecified { get; set; }

        public virtual ICollection<EtrainRadioChanges> EtrainRadioChanges { get; set; }
    }
}
