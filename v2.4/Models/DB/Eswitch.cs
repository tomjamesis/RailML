using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Eswitch
    {
        public Eswitch()
        {
            Econnections = new HashSet<Econnections>();
        }

        public short EswitchId { get; set; }
        public short Connection { get; set; }

        public virtual TswitchConnectionData ConnectionNavigation { get; set; }
        public virtual ICollection<Econnections> Econnections { get; set; }
    }
}
