using System;
using System.Collections.Generic;

namespace Models.DB
{
    public partial class TserviceSection
    {
        public TserviceSection()
        {
            EserviceSections = new HashSet<EserviceSections>();
        }

        public short TserviceSectionId { get; set; }
        public string ParentServiceSectionRef { get; set; }
        public bool RampValue { get; set; }
        public bool RampValueSpecified { get; set; }
        public bool MaintenanceValue { get; set; }
        public bool MaintenanceValueSpecified { get; set; }
        public bool LoadingFacilityValue { get; set; }
        public bool LoadingFacilityValueSpecified { get; set; }
        public bool CleaningValue { get; set; }
        public bool CleaningValueSpecified { get; set; }
        public bool FuelingValue { get; set; }
        public bool FuelingValueSpecified { get; set; }
        public bool ParkingValue { get; set; }
        public bool ParkingValueSpecified { get; set; }
        public bool PreheatingValue { get; set; }
        public bool PreheatingValueSpecified { get; set; }

        public virtual ICollection<EserviceSections> EserviceSections { get; set; }
    }
}
