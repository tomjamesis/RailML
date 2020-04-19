//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Models.XsdConvert.genericRailML
{
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tOrganizationalUnits", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TOrganizationalUnits
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<TInfrastructureManager> _infrastructureManager;
        
        /// <summary>
        /// <para>de: Infrastrukturbetreiber</para>
        /// </summary>
        [XmlElementAttribute("infrastructureManager", Order=0)]
        public Collection<TInfrastructureManager> InfrastructureManager
        {
            get
            {
                return this._infrastructureManager;
            }
            private set
            {
                this._infrastructureManager = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InfrastructureManager-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the InfrastructureManager collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool InfrastructureManagerSpecified
        {
            get
            {
                return (this.InfrastructureManager.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TOrganizationalUnits" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TOrganizationalUnits" /> class.</para>
        /// </summary>
        public TOrganizationalUnits()
        {
            this._infrastructureManager = new Collection<TInfrastructureManager>();
            this._vehicleManufacturer = new Collection<TVehicleManufacturer>();
            this._vehicleOperator = new Collection<TVehicleOperator>();
            this._customer = new Collection<TCustomer>();
            this._railwayUndertaking = new Collection<TRailwayUndertaking>();
            this._operationalUndertaking = new Collection<TOperationalUndertaking>();
            this._concessionaire = new Collection<TConcessionaire>();
            this._contractor = new Collection<TContractor>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TVehicleManufacturer> _vehicleManufacturer;
        
        /// <summary>
        /// <para>de: Fahrzeughersteller</para>
        /// </summary>
        [XmlElementAttribute("vehicleManufacturer", Order=1)]
        public Collection<TVehicleManufacturer> VehicleManufacturer
        {
            get
            {
                return this._vehicleManufacturer;
            }
            private set
            {
                this._vehicleManufacturer = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die VehicleManufacturer-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the VehicleManufacturer collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool VehicleManufacturerSpecified
        {
            get
            {
                return (this.VehicleManufacturer.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TVehicleOperator> _vehicleOperator;
        
        /// <summary>
        /// <para>Some kind of subcontractor (railway undertaking) that operates the vehicle, if different from the one that is responsible for the commercial service</para>
        /// </summary>
        [XmlElementAttribute("vehicleOperator", Order=2)]
        public Collection<TVehicleOperator> VehicleOperator
        {
            get
            {
                return this._vehicleOperator;
            }
            private set
            {
                this._vehicleOperator = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die VehicleOperator-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the VehicleOperator collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool VehicleOperatorSpecified
        {
            get
            {
                return (this.VehicleOperator.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TCustomer> _customer;
        
        /// <summary>
        /// <para>The authority or enterprise that ordered the transportation service, i.e., an integrated transit system</para>
        /// </summary>
        [XmlElementAttribute("customer", Order=3)]
        public Collection<TCustomer> Customer
        {
            get
            {
                return this._customer;
            }
            private set
            {
                this._customer = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Customer-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Customer collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool CustomerSpecified
        {
            get
            {
                return (this.Customer.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TRailwayUndertaking> _railwayUndertaking;
        
        /// <summary>
        /// <para>The undertaking that is commercially responsible for the service</para>
        /// </summary>
        [XmlElementAttribute("railwayUndertaking", Order=4)]
        public Collection<TRailwayUndertaking> RailwayUndertaking
        {
            get
            {
                return this._railwayUndertaking;
            }
            private set
            {
                this._railwayUndertaking = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RailwayUndertaking-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RailwayUndertaking collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool RailwayUndertakingSpecified
        {
            get
            {
                return (this.RailwayUndertaking.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TOperationalUndertaking> _operationalUndertaking;
        
        /// <summary>
        /// <para>The unit that is responsible for the operational planning of this service</para>
        /// </summary>
        [XmlElementAttribute("operationalUndertaking", Order=5)]
        public Collection<TOperationalUndertaking> OperationalUndertaking
        {
            get
            {
                return this._operationalUndertaking;
            }
            private set
            {
                this._operationalUndertaking = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OperationalUndertaking-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OperationalUndertaking collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool OperationalUndertakingSpecified
        {
            get
            {
                return (this.OperationalUndertaking.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TConcessionaire> _concessionaire;
        
        /// <summary>
        /// <para>de: Konzessionsinhaber</para>
        /// </summary>
        [XmlElementAttribute("concessionaire", Order=6)]
        public Collection<TConcessionaire> Concessionaire
        {
            get
            {
                return this._concessionaire;
            }
            private set
            {
                this._concessionaire = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Concessionaire-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Concessionaire collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool ConcessionaireSpecified
        {
            get
            {
                return (this.Concessionaire.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TContractor> _contractor;
        
        /// <summary>
        /// <para>Any unit or undertaking that has a binding not defined in a neighbouring element</para>
        /// </summary>
        [XmlElementAttribute("contractor", Order=7)]
        public Collection<TContractor> Contractor
        {
            get
            {
                return this._contractor;
            }
            private set
            {
                this._contractor = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Contractor-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Contractor collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool ContractorSpecified
        {
            get
            {
                return (this.Contractor.Count != 0);
            }
        }
    }
}