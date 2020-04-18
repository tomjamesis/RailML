using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EstopPosts
    {
        public EstopPosts()
        {
            EocsElements = new HashSet<EocsElements>();
        }

        public long EstopPostsId { get; set; }
        public short StopPost { get; set; }

        public virtual TstopPost StopPostNavigation { get; set; }
        public virtual ICollection<EocsElements> EocsElements { get; set; }
    }
}
