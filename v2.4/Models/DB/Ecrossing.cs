using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Ecrossing
    {
        public Ecrossing()
        {
            Econnections = new HashSet<Econnections>();
        }

        public short EcrossingId { get; set; }
        public short Connection { get; set; }

        public virtual TswitchConnectionData ConnectionNavigation { get; set; }
        public virtual ICollection<Econnections> Econnections { get; set; }
    }
}
