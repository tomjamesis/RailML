using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Epassenger
    {
        public Epassenger()
        {
            Ewagon = new HashSet<Ewagon>();
        }

        public short EpassengerId { get; set; }
        public long Gangway { get; set; }
        public short Doors { get; set; }
        public long Tilting { get; set; }

        public virtual Edoors DoorsNavigation { get; set; }
        public virtual Tgangway GangwayNavigation { get; set; }
        public virtual Ttilting TiltingNavigation { get; set; }
        public virtual ICollection<Ewagon> Ewagon { get; set; }
    }
}
