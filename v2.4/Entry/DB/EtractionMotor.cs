using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class EtractionMotor
    {
        public EtractionMotor()
        {
            Epropulsion = new HashSet<Epropulsion>();
        }

        public short EtractionMotorId { get; set; }
        public short Efficiency { get; set; }
        public short MechanicalLosses { get; set; }

        public virtual TefficiencyCurve EfficiencyNavigation { get; set; }
        public virtual Tlosses MechanicalLossesNavigation { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
    }
}
