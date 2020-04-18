using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tengine
    {
        public long TengineId { get; set; }
        public string AxleDriveType { get; set; }
        public decimal HaulageLoadValue { get; set; }
        public bool HaulageLoadValueSpecified { get; set; }
    }
}
