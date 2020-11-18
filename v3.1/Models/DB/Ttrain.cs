using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ttrain
    {
        public short TtrainId { get; set; }
        public short Type { get; set; }
        public string TrainNumber { get; set; }
        public string AdditionalTrainNumber { get; set; }
        public byte ScopeValue { get; set; }
        public bool ScopeValueSpecified { get; set; }
        public string ProcessStatus { get; set; }
        public string Remarks { get; set; }
        public bool CancellationValue { get; set; }
        public bool CancellationValueSpecified { get; set; }

        public virtual TtrainScope ScopeValueNavigation { get; set; }
        public virtual Type TypeNavigation { get; set; }
    }
}
