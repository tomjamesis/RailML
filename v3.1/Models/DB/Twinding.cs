using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Twinding
    {
        public Twinding()
        {
            Etransformer = new HashSet<Etransformer>();
        }

        public long TwindingId { get; set; }
        public string AssemblyName { get; set; }
        public decimal NominalVoltageValue { get; set; }
        public bool NominalVoltageValueSpecified { get; set; }
        public decimal NominalCurrentValue { get; set; }
        public bool NominalCurrentValueSpecified { get; set; }
        public decimal TransformationRatioValue { get; set; }
        public bool TransformationRatioValueSpecified { get; set; }
        public decimal PrimaryResistanceValue { get; set; }
        public bool PrimaryResistanceValueSpecified { get; set; }
        public decimal SecondaryResistanceValue { get; set; }
        public bool SecondaryResistanceValueSpecified { get; set; }
        public decimal PrimaryLeakageInductanceValue { get; set; }
        public bool PrimaryLeakageInductanceValueSpecified { get; set; }
        public decimal SecondaryLeakageInductanceValue { get; set; }
        public bool SecondaryLeakageInductanceValueSpecified { get; set; }

        public virtual ICollection<Etransformer> Etransformer { get; set; }
    }
}
