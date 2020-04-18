using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TspeedChange
    {
        public TspeedChange()
        {
            EspeedChanges = new HashSet<EspeedChanges>();
        }

        public short TspeedChangeId { get; set; }
        public string TrainCategory { get; set; }
        public string EtcsTrainCategory { get; set; }
        public string ProfileRef { get; set; }
        public string Status { get; set; }
        public string Vmax { get; set; }
        public string TrainRelation { get; set; }
        public bool MandatoryStopValue { get; set; }
        public bool MandatoryStopValueSpecified { get; set; }
        public bool SignalisedValue { get; set; }
        public bool SignalisedValueSpecified { get; set; }

        public virtual ICollection<EspeedChanges> EspeedChanges { get; set; }
    }
}
