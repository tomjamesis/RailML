using System;
using System.Collections.Generic;

namespace Entry.DB
{
    public partial class TorganizationalUnits
    {
        public TorganizationalUnits()
        {
            Tmetadata = new HashSet<Tmetadata>();
        }

        public long TorganizationalUnitsId { get; set; }
        public short InfrastructureManager { get; set; }
        public short VehicleManufacturer { get; set; }
        public short VehicleOperator { get; set; }
        public short Customer { get; set; }
        public short RailwayUndertaking { get; set; }
        public short OperationalUndertaking { get; set; }
        public short Concessionaire { get; set; }
        public short Contractor { get; set; }

        public virtual Tconcessionaire ConcessionaireNavigation { get; set; }
        public virtual Tcontractor ContractorNavigation { get; set; }
        public virtual Tcustomer CustomerNavigation { get; set; }
        public virtual TinfrastructureManager InfrastructureManagerNavigation { get; set; }
        public virtual ToperationalUndertaking OperationalUndertakingNavigation { get; set; }
        public virtual TrailwayUndertaking RailwayUndertakingNavigation { get; set; }
        public virtual TvehicleManufacturer VehicleManufacturerNavigation { get; set; }
        public virtual TvehicleOperator VehicleOperatorNavigation { get; set; }
        public virtual ICollection<Tmetadata> Tmetadata { get; set; }
    }
}
