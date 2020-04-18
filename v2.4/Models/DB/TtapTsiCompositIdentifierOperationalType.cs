using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtapTsiCompositIdentifierOperationalType
    {
        public long TtapTsiCompositIdentifierOperationalTypeId { get; set; }
        public string ObjectType { get; set; }
        public string CompanyCode { get; set; }
        public string Core { get; set; }
        public string Variant { get; set; }
        public string TimetableYear { get; set; }
        public DateTime StartDateValue { get; set; }
        public bool StartDateValueSpecified { get; set; }
    }
}
