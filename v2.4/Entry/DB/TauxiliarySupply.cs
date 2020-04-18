using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TauxiliarySupply
    {
        public long TauxiliarySupplyId { get; set; }
        public decimal Power { get; set; }
        public decimal PowerPhiValue { get; set; }
        public bool PowerPhiValueSpecified { get; set; }
        public decimal ResistanceValue { get; set; }
        public bool ResistanceValueSpecified { get; set; }
        public decimal PowerBrakingValue { get; set; }
        public bool PowerBrakingValueSpecified { get; set; }
        public decimal PowerPhiBrakingValue { get; set; }
        public bool PowerPhiBrakingValueSpecified { get; set; }
        public decimal ResistanceBrakingValue { get; set; }
        public bool ResistanceBrakingValueSpecified { get; set; }
    }
}
