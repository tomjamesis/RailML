using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainPart
    {
        public short TtrainPartId { get; set; }
        public string Line { get; set; }
        public string TrainLine { get; set; }
        public string TrainNumber { get; set; }
        public string AdditionalTrainNumber { get; set; }
        public string ProcessStatus { get; set; }
        public string Debitcode { get; set; }
        public string Remarks { get; set; }
        public string TimetablePeriodRef { get; set; }
        public string CategoryRef { get; set; }
        public string Operator { get; set; }
        public bool CancellationValue { get; set; }
        public bool CancellationValueSpecified { get; set; }
    }
}
