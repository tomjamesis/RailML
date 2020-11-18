using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tmetadata
    {
        public Tmetadata()
        {
            Railml = new HashSet<Railml>();
        }

        public short TmetadataId { get; set; }
        public long OrganizationalUnits { get; set; }

        public virtual TorganizationalUnits OrganizationalUnitsNavigation { get; set; }
        public virtual ICollection<Railml> Railml { get; set; }
    }
}
