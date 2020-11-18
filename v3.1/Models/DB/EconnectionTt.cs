using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class EconnectionTt
    {
        public EconnectionTt()
        {
            EconnectionsTt = new HashSet<EconnectionsTt>();
        }

        public short EconnectionTtid { get; set; }
        public long ExternalReference { get; set; }
        public short AnnotationRef { get; set; }

        public virtual TannotationRef AnnotationRefNavigation { get; set; }
        public virtual EexternalReference ExternalReferenceNavigation { get; set; }
        public virtual ICollection<EconnectionsTt> EconnectionsTt { get; set; }
    }
}
