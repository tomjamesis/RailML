using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TbasicBrakeTypeAuxiliaryBrakes
    {
        public TbasicBrakeTypeAuxiliaryBrakes()
        {
            TbasicBrakeType = new HashSet<TbasicBrakeType>();
        }

        public long TbasicBrakeTypeAuxiliaryBrakesId { get; set; }
        public byte BrakeUseValue { get; set; }
        public bool BrakeUseValueSpecified { get; set; }
        public bool Hvalue { get; set; }
        public bool HvalueSpecified { get; set; }
        public bool Evalue { get; set; }
        public bool EvalueSpecified { get; set; }
        public bool MgValue { get; set; }
        public bool MgValueSpecified { get; set; }
        public bool WbValue { get; set; }
        public bool WbValueSpecified { get; set; }
        public bool EpValue { get; set; }
        public bool EpValueSpecified { get; set; }

        public virtual TbrakeUse BrakeUseValueNavigation { get; set; }
        public virtual ICollection<TbasicBrakeType> TbasicBrakeType { get; set; }
    }
}
