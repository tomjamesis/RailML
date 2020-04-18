using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Type
    {
        public Type()
        {
            TmileageChange = new HashSet<TmileageChange>();
            TspecialService = new HashSet<TspecialService>();
            Ttrain = new HashSet<Ttrain>();
        }

        public short TypeId { get; set; }

        public virtual ICollection<TmileageChange> TmileageChange { get; set; }
        public virtual ICollection<TspecialService> TspecialService { get; set; }
        public virtual ICollection<Ttrain> Ttrain { get; set; }
    }
}
