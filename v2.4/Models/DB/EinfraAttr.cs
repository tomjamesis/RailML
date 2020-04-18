using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EinfraAttr
    {
        public EinfraAttr()
        {
            EinfraAttrGroup = new HashSet<EinfraAttrGroup>();
        }

        public short EinfraAttrId { get; set; }
        public long Owner { get; set; }
        public long OperationMode { get; set; }
        public long TrainProtection { get; set; }
        public long Electrification { get; set; }
        public long PowerTransmission { get; set; }
        public long AxleWeight { get; set; }
        public long Gauge { get; set; }
        public long ClearanceGauge { get; set; }
        public long Speeds { get; set; }
        public long EpsgCode { get; set; }
        public long TrainRadio { get; set; }
        public long GeneralInfraAttributes { get; set; }

        public virtual TaxleWeight AxleWeightNavigation { get; set; }
        public virtual TclearanceGaugeType ClearanceGaugeNavigation { get; set; }
        public virtual Telectrification ElectrificationNavigation { get; set; }
        public virtual TepsgCode EpsgCodeNavigation { get; set; }
        public virtual Tgauge GaugeNavigation { get; set; }
        public virtual EgeneralInfraAttributes GeneralInfraAttributesNavigation { get; set; }
        public virtual ToperationMode OperationModeNavigation { get; set; }
        public virtual Towner OwnerNavigation { get; set; }
        public virtual TpowerTransmission PowerTransmissionNavigation { get; set; }
        public virtual Espeeds SpeedsNavigation { get; set; }
        public virtual TtrainProtection TrainProtectionNavigation { get; set; }
        public virtual TtrainRadioAttributes TrainRadioNavigation { get; set; }
        public virtual ICollection<EinfraAttrGroup> EinfraAttrGroup { get; set; }
    }
}
