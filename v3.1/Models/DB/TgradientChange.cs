using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TgradientChange
    {
        public TgradientChange()
        {
            EgradientChanges = new HashSet<EgradientChanges>();
        }

        public short TgradientChangeId { get; set; }
        public decimal Slope { get; set; }
        public decimal TransitionLenghtValue { get; set; }
        public bool TransitionLenghtValueSpecified { get; set; }
        public decimal TransitionRadiusValue { get; set; }
        public bool TransitionRadiusValueSpecified { get; set; }

        public virtual ICollection<EgradientChanges> EgradientChanges { get; set; }
    }
}
