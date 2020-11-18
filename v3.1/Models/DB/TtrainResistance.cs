using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TtrainResistance
    {
        public TtrainResistance()
        {
            Eformation = new HashSet<Eformation>();
        }

        public short TtrainResistanceId { get; set; }
        public decimal TunnelFactorValue { get; set; }
        public bool TunnelFactorValueSpecified { get; set; }
        public decimal StrahlFactorValue { get; set; }
        public bool StrahlFactorValueSpecified { get; set; }
        public bool DaviesMassDependentValue { get; set; }
        public bool DaviesMassDependentValueSpecified { get; set; }
        public decimal DaviesFactorAvalue { get; set; }
        public bool DaviesFactorAvalueSpecified { get; set; }
        public decimal DaviesFactorBvalue { get; set; }
        public bool DaviesFactorBvalueSpecified { get; set; }
        public decimal DaviesFactorCvalue { get; set; }
        public bool DaviesFactorCvalueSpecified { get; set; }

        public virtual ICollection<Eformation> Eformation { get; set; }
    }
}
