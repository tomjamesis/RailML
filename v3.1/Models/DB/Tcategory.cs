using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class Tcategory
    {
        public short TcategoryId { get; set; }
        public byte TrainUsageValue { get; set; }
        public bool TrainUsageValueSpecified { get; set; }
        public bool DeadrunValue { get; set; }
        public bool DeadrunValueSpecified { get; set; }
        public string CategoryPriority { get; set; }

        public virtual TusageType TrainUsageValueNavigation { get; set; }
    }
}
