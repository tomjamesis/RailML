using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class Tholiday
    {
        public Tholiday()
        {
            Eholidays = new HashSet<Eholidays>();
        }

        public long TholidayId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Eholidays> Eholidays { get; set; }
    }
}
