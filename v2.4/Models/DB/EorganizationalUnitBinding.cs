using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EorganizationalUnitBinding
    {
        public EorganizationalUnitBinding()
        {
            EexternalReferenceTrainNumber = new HashSet<EexternalReferenceTrainNumber>();
            EtrainPart = new HashSet<EtrainPart>();
        }

        public long EorganizationalUnitBindingId { get; set; }
        public long VehicleOperator { get; set; }
        public long Customer { get; set; }
        public long RailwayUndertaking { get; set; }
        public long OperationalUndertaking { get; set; }
        public long Concessionaire { get; set; }
        public long Contractor { get; set; }
        public string Any { get; set; }

        public virtual TelementWithReference VehicleOperatorNavigation { get; set; }
        public virtual ICollection<EexternalReferenceTrainNumber> EexternalReferenceTrainNumber { get; set; }
        public virtual ICollection<EtrainPart> EtrainPart { get; set; }
    }
}
