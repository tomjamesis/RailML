using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TefficiencyCurve
    {
        public TefficiencyCurve()
        {
            EfourQuadrantChopper = new HashSet<EfourQuadrantChopper>();
            Egear = new HashSet<Egear>();
            Epropulsion = new HashSet<Epropulsion>();
            Estorage = new HashSet<Estorage>();
            EtractionInverter = new HashSet<EtractionInverter>();
            EtractionMotor = new HashSet<EtractionMotor>();
            Etransformer = new HashSet<Etransformer>();
        }

        public short TefficiencyCurveId { get; set; }

        public virtual ICollection<EfourQuadrantChopper> EfourQuadrantChopper { get; set; }
        public virtual ICollection<Egear> Egear { get; set; }
        public virtual ICollection<Epropulsion> Epropulsion { get; set; }
        public virtual ICollection<Estorage> Estorage { get; set; }
        public virtual ICollection<EtractionInverter> EtractionInverter { get; set; }
        public virtual ICollection<EtractionMotor> EtractionMotor { get; set; }
        public virtual ICollection<Etransformer> Etransformer { get; set; }
    }
}
