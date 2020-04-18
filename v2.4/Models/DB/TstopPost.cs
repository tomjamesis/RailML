using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TstopPost
    {
        public TstopPost()
        {
            EstopPosts = new HashSet<EstopPosts>();
        }

        public short TstopPostId { get; set; }
        public long ValidForMovements { get; set; }
        public long SignalRef { get; set; }
        public string TrainRelation { get; set; }
        public string PlatformEdgeRef { get; set; }
        public decimal TrainLengthValue { get; set; }
        public bool TrainLengthValueSpecified { get; set; }
        public string AxleCount { get; set; }
        public string WagonCount { get; set; }
        public string VerbalConstraints { get; set; }
        public bool VirtualValue { get; set; }
        public bool VirtualValueSpecified { get; set; }
        public string OcpRef { get; set; }

        public virtual TelementWithReference SignalRefNavigation { get; set; }
        public virtual TvalidForMovements ValidForMovementsNavigation { get; set; }
        public virtual ICollection<EstopPosts> EstopPosts { get; set; }
    }
}
