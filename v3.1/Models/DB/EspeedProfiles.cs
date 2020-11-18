using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EspeedProfiles
    {
        public EspeedProfiles()
        {
            Infrastructure = new HashSet<Infrastructure>();
        }

        public long EspeedProfilesId { get; set; }
        public short SpeedProfile { get; set; }

        public virtual TspeedProfile SpeedProfileNavigation { get; set; }
        public virtual ICollection<Infrastructure> Infrastructure { get; set; }
    }
}
