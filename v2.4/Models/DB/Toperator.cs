using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Toperator
    {
        public long ToperatorId { get; set; }
        public string OperatorName { get; set; }
        public string VehicleOperatorRef { get; set; }
        public string OperatorClass { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
        public DateTime EndDateValue { get; set; }
        public bool EndDateValueSpecified { get; set; }
    }
}
