using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entry.DB
{
    public partial class XSDtoSQLContext : DbContext
    {
        public XSDtoSQLContext()
        {
        }

        public XSDtoSQLContext(DbContextOptions<XSDtoSQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contributor> Contributor { get; set; }
        public virtual DbSet<Coverage> Coverage { get; set; }
        public virtual DbSet<Creator> Creator { get; set; }
        public virtual DbSet<Date> Date { get; set; }
        public virtual DbSet<Description> Description { get; set; }
        public virtual DbSet<Eannotation> Eannotation { get; set; }
        public virtual DbSet<Eannotations> Eannotations { get; set; }
        public virtual DbSet<EarrivalDepartureTimes> EarrivalDepartureTimes { get; set; }
        public virtual DbSet<Eattributes> Eattributes { get; set; }
        public virtual DbSet<EauxiliarySupply> EauxiliarySupply { get; set; }
        public virtual DbSet<EaxleWeightChanges> EaxleWeightChanges { get; set; }
        public virtual DbSet<Ebalises> Ebalises { get; set; }
        public virtual DbSet<Eblock> Eblock { get; set; }
        public virtual DbSet<EblockPartSequence> EblockPartSequence { get; set; }
        public virtual DbSet<EblockParts> EblockParts { get; set; }
        public virtual DbSet<Eblocks> Eblocks { get; set; }
        public virtual DbSet<Eborder> Eborder { get; set; }
        public virtual DbSet<EbrakeUsage> EbrakeUsage { get; set; }
        public virtual DbSet<Ebridge> Ebridge { get; set; }
        public virtual DbSet<Ebridges> Ebridges { get; set; }
        public virtual DbSet<Ecategories> Ecategories { get; set; }
        public virtual DbSet<Ecategory> Ecategory { get; set; }
        public virtual DbSet<Ecirculations> Ecirculations { get; set; }
        public virtual DbSet<Eclassification> Eclassification { get; set; }
        public virtual DbSet<EclearanceGaugeChanges> EclearanceGaugeChanges { get; set; }
        public virtual DbSet<EconnectionTt> EconnectionTt { get; set; }
        public virtual DbSet<Econnections> Econnections { get; set; }
        public virtual DbSet<EconnectionsTt> EconnectionsTt { get; set; }
        public virtual DbSet<Econtrollers> Econtrollers { get; set; }
        public virtual DbSet<Ecouplers> Ecouplers { get; set; }
        public virtual DbSet<EcrossSections> EcrossSections { get; set; }
        public virtual DbSet<EcrossedElements> EcrossedElements { get; set; }
        public virtual DbSet<Ecrossing> Ecrossing { get; set; }
        public virtual DbSet<EcurvingLimitation> EcurvingLimitation { get; set; }
        public virtual DbSet<Ederailers> Ederailers { get; set; }
        public virtual DbSet<Edoors> Edoors { get; set; }
        public virtual DbSet<EelectricalCoupler> EelectricalCoupler { get; set; }
        public virtual DbSet<EelectrificationChanges> EelectrificationChanges { get; set; }
        public virtual DbSet<Eengine> Eengine { get; set; }
        public virtual DbSet<Eequipment> Eequipment { get; set; }
        public virtual DbSet<EequipmentUsage> EequipmentUsage { get; set; }
        public virtual DbSet<Eetcs> Eetcs { get; set; }
        public virtual DbSet<EexternalReference> EexternalReference { get; set; }
        public virtual DbSet<EexternalReferenceInformation> EexternalReferenceInformation { get; set; }
        public virtual DbSet<EexternalReferenceLineNumber> EexternalReferenceLineNumber { get; set; }
        public virtual DbSet<EexternalReferenceTrainNumber> EexternalReferenceTrainNumber { get; set; }
        public virtual DbSet<Eformation> Eformation { get; set; }
        public virtual DbSet<EformationTt> EformationTt { get; set; }
        public virtual DbSet<Eformations> Eformations { get; set; }
        public virtual DbSet<EfourQuadrantChopper> EfourQuadrantChopper { get; set; }
        public virtual DbSet<EgaugeChanges> EgaugeChanges { get; set; }
        public virtual DbSet<Egear> Egear { get; set; }
        public virtual DbSet<EgeneralInfraAttribute> EgeneralInfraAttribute { get; set; }
        public virtual DbSet<EgeneralInfraAttributes> EgeneralInfraAttributes { get; set; }
        public virtual DbSet<EgeoMappings> EgeoMappings { get; set; }
        public virtual DbSet<Egoods> Egoods { get; set; }
        public virtual DbSet<EgradientChanges> EgradientChanges { get; set; }
        public virtual DbSet<Eholidays> Eholidays { get; set; }
        public virtual DbSet<EinfraAttr> EinfraAttr { get; set; }
        public virtual DbSet<EinfraAttrGroup> EinfraAttrGroup { get; set; }
        public virtual DbSet<EinfraAttrGroupRefs> EinfraAttrGroupRefs { get; set; }
        public virtual DbSet<EinfrastructureVisualization> EinfrastructureVisualization { get; set; }
        public virtual DbSet<ElementContainer> ElementContainer { get; set; }
        public virtual DbSet<ElevelCrossing> ElevelCrossing { get; set; }
        public virtual DbSet<ElevelCrossings> ElevelCrossings { get; set; }
        public virtual DbSet<Eline> Eline { get; set; }
        public virtual DbSet<ElineVis> ElineVis { get; set; }
        public virtual DbSet<EloadLimit> EloadLimit { get; set; }
        public virtual DbSet<EloadLimitMatrix> EloadLimitMatrix { get; set; }
        public virtual DbSet<ElocallyControlledArea> ElocallyControlledArea { get; set; }
        public virtual DbSet<Elocks> Elocks { get; set; }
        public virtual DbSet<EmaintenanceIntervals> EmaintenanceIntervals { get; set; }
        public virtual DbSet<EmechanicalCoupler> EmechanicalCoupler { get; set; }
        public virtual DbSet<EmileageChanges> EmileageChanges { get; set; }
        public virtual DbSet<Emonitoring> Emonitoring { get; set; }
        public virtual DbSet<Eocp> Eocp { get; set; }
        public virtual DbSet<EocpPropEquipment> EocpPropEquipment { get; set; }
        public virtual DbSet<EocpPropOperational> EocpPropOperational { get; set; }
        public virtual DbSet<EocpPropOther> EocpPropOther { get; set; }
        public virtual DbSet<EocpTt> EocpTt { get; set; }
        public virtual DbSet<EocpVis> EocpVis { get; set; }
        public virtual DbSet<EocpsTt> EocpsTt { get; set; }
        public virtual DbSet<EocsElements> EocsElements { get; set; }
        public virtual DbSet<EoperatingDay> EoperatingDay { get; set; }
        public virtual DbSet<EoperatingPeriod> EoperatingPeriod { get; set; }
        public virtual DbSet<EoperatingPeriodRef> EoperatingPeriodRef { get; set; }
        public virtual DbSet<EoperatingPeriods> EoperatingPeriods { get; set; }
        public virtual DbSet<EoperationControlPoints> EoperationControlPoints { get; set; }
        public virtual DbSet<EoperationModeChanges> EoperationModeChanges { get; set; }
        public virtual DbSet<Eoperator> Eoperator { get; set; }
        public virtual DbSet<EorganizationalUnitBinding> EorganizationalUnitBinding { get; set; }
        public virtual DbSet<EownerChanges> EownerChanges { get; set; }
        public virtual DbSet<Epantograph> Epantograph { get; set; }
        public virtual DbSet<Epassenger> Epassenger { get; set; }
        public virtual DbSet<EpassengerFacility> EpassengerFacility { get; set; }
        public virtual DbSet<EpassengerFacilityTt> EpassengerFacilityTt { get; set; }
        public virtual DbSet<EplatformEdges> EplatformEdges { get; set; }
        public virtual DbSet<EpneumaticCoupler> EpneumaticCoupler { get; set; }
        public virtual DbSet<EpowerTransmissionChanges> EpowerTransmissionChanges { get; set; }
        public virtual DbSet<Epropulsion> Epropulsion { get; set; }
        public virtual DbSet<EpulsePattern> EpulsePattern { get; set; }
        public virtual DbSet<EpulsePatternValueTable> EpulsePatternValueTable { get; set; }
        public virtual DbSet<EradiusChanges> EradiusChanges { get; set; }
        public virtual DbSet<EreplacedTrains> EreplacedTrains { get; set; }
        public virtual DbSet<EreplacementOf> EreplacementOf { get; set; }
        public virtual DbSet<EreservationInfo> EreservationInfo { get; set; }
        public virtual DbSet<Erostering> Erostering { get; set; }
        public virtual DbSet<Erosterings> Erosterings { get; set; }
        public virtual DbSet<EsectionTt> EsectionTt { get; set; }
        public virtual DbSet<EserviceSections> EserviceSections { get; set; }
        public virtual DbSet<EsignalGroup> EsignalGroup { get; set; }
        public virtual DbSet<EsignalGroups> EsignalGroups { get; set; }
        public virtual DbSet<Esignals> Esignals { get; set; }
        public virtual DbSet<EspeedChanges> EspeedChanges { get; set; }
        public virtual DbSet<EspeedProfiles> EspeedProfiles { get; set; }
        public virtual DbSet<Espeeds> Espeeds { get; set; }
        public virtual DbSet<Estatistic> Estatistic { get; set; }
        public virtual DbSet<Estatistics> Estatistics { get; set; }
        public virtual DbSet<EstopActivities> EstopActivities { get; set; }
        public virtual DbSet<EstopDescription> EstopDescription { get; set; }
        public virtual DbSet<EstopPosts> EstopPosts { get; set; }
        public virtual DbSet<Estorage> Estorage { get; set; }
        public virtual DbSet<Eswitch> Eswitch { get; set; }
        public virtual DbSet<EtapTsiTransportOperationalIdentifier> EtapTsiTransportOperationalIdentifier { get; set; }
        public virtual DbSet<EtimetablePeriod> EtimetablePeriod { get; set; }
        public virtual DbSet<EtimetablePeriods> EtimetablePeriods { get; set; }
        public virtual DbSet<Etrack> Etrack { get; set; }
        public virtual DbSet<EtrackBegin> EtrackBegin { get; set; }
        public virtual DbSet<EtrackConditions> EtrackConditions { get; set; }
        public virtual DbSet<EtrackElementVis> EtrackElementVis { get; set; }
        public virtual DbSet<EtrackElements> EtrackElements { get; set; }
        public virtual DbSet<EtrackEnd> EtrackEnd { get; set; }
        public virtual DbSet<EtrackGroups> EtrackGroups { get; set; }
        public virtual DbSet<EtrackNode> EtrackNode { get; set; }
        public virtual DbSet<EtrackTopology> EtrackTopology { get; set; }
        public virtual DbSet<EtrackVis> EtrackVis { get; set; }
        public virtual DbSet<Etracks> Etracks { get; set; }
        public virtual DbSet<EtractionInverter> EtractionInverter { get; set; }
        public virtual DbSet<EtractionMotor> EtractionMotor { get; set; }
        public virtual DbSet<Etrain> Etrain { get; set; }
        public virtual DbSet<EtrainDetectionElements> EtrainDetectionElements { get; set; }
        public virtual DbSet<EtrainGroup> EtrainGroup { get; set; }
        public virtual DbSet<EtrainGroups> EtrainGroups { get; set; }
        public virtual DbSet<EtrainOrder> EtrainOrder { get; set; }
        public virtual DbSet<EtrainPart> EtrainPart { get; set; }
        public virtual DbSet<EtrainPartSequence> EtrainPartSequence { get; set; }
        public virtual DbSet<EtrainParts> EtrainParts { get; set; }
        public virtual DbSet<EtrainProtectionChanges> EtrainProtectionChanges { get; set; }
        public virtual DbSet<EtrainProtectionElements> EtrainProtectionElements { get; set; }
        public virtual DbSet<EtrainRadio> EtrainRadio { get; set; }
        public virtual DbSet<EtrainRadioChanges> EtrainRadioChanges { get; set; }
        public virtual DbSet<Etrains> Etrains { get; set; }
        public virtual DbSet<Etransformer> Etransformer { get; set; }
        public virtual DbSet<Etunnel> Etunnel { get; set; }
        public virtual DbSet<Etunnels> Etunnels { get; set; }
        public virtual DbSet<Evehicle> Evehicle { get; set; }
        public virtual DbSet<EvehicleBrake> EvehicleBrake { get; set; }
        public virtual DbSet<EvehicleBrakes> EvehicleBrakes { get; set; }
        public virtual DbSet<Evehicles> Evehicles { get; set; }
        public virtual DbSet<Ewagon> Ewagon { get; set; }
        public virtual DbSet<Format> Format { get; set; }
        public virtual DbSet<Identifier> Identifier { get; set; }
        public virtual DbSet<Infrastructure> Infrastructure { get; set; }
        public virtual DbSet<InfrastructureVisualizations> InfrastructureVisualizations { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Railml> Railml { get; set; }
        public virtual DbSet<Relation> Relation { get; set; }
        public virtual DbSet<Rights> Rights { get; set; }
        public virtual DbSet<Rollingstock> Rollingstock { get; set; }
        public virtual DbSet<SimpleLiteral> SimpleLiteral { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<TadditionalName> TadditionalName { get; set; }
        public virtual DbSet<TadditionalOcpName> TadditionalOcpName { get; set; }
        public virtual DbSet<TairBrakeApplicationPosition> TairBrakeApplicationPosition { get; set; }
        public virtual DbSet<Tannotation> Tannotation { get; set; }
        public virtual DbSet<TannotationRef> TannotationRef { get; set; }
        public virtual DbSet<TannotationText> TannotationText { get; set; }
        public virtual DbSet<TarrivalDepartureTimes> TarrivalDepartureTimes { get; set; }
        public virtual DbSet<Tattribute> Tattribute { get; set; }
        public virtual DbSet<TauxiliarySupply> TauxiliarySupply { get; set; }
        public virtual DbSet<TauxiliarySupplySystem> TauxiliarySupplySystem { get; set; }
        public virtual DbSet<TaxleWeight> TaxleWeight { get; set; }
        public virtual DbSet<TaxleWeightChange> TaxleWeightChange { get; set; }
        public virtual DbSet<Tbalise> Tbalise { get; set; }
        public virtual DbSet<TbaliseGroup> TbaliseGroup { get; set; }
        public virtual DbSet<TbaliseLinkReaction> TbaliseLinkReaction { get; set; }
        public virtual DbSet<TbaliseRefInGroup> TbaliseRefInGroup { get; set; }
        public virtual DbSet<TbasePlacedElement> TbasePlacedElement { get; set; }
        public virtual DbSet<TbaseServiceSection> TbaseServiceSection { get; set; }
        public virtual DbSet<TbasicBrakeOperation> TbasicBrakeOperation { get; set; }
        public virtual DbSet<TbasicBrakeType> TbasicBrakeType { get; set; }
        public virtual DbSet<TbasicBrakeTypeAuxiliaryBrakes> TbasicBrakeTypeAuxiliaryBrakes { get; set; }
        public virtual DbSet<Tblock> Tblock { get; set; }
        public virtual DbSet<TblockPart> TblockPart { get; set; }
        public virtual DbSet<TblockPartRef> TblockPartRef { get; set; }
        public virtual DbSet<TblockPartSequence> TblockPartSequence { get; set; }
        public virtual DbSet<Tbooking> Tbooking { get; set; }
        public virtual DbSet<Tborder> Tborder { get; set; }
        public virtual DbSet<TbrakeUse> TbrakeUse { get; set; }
        public virtual DbSet<Tbraking> Tbraking { get; set; }
        public virtual DbSet<Tbridge> Tbridge { get; set; }
        public virtual DbSet<TbufferStop> TbufferStop { get; set; }
        public virtual DbSet<TcabPositionType> TcabPositionType { get; set; }
        public virtual DbSet<Tcategory> Tcategory { get; set; }
        public virtual DbSet<Tcirculation> Tcirculation { get; set; }
        public virtual DbSet<TclearanceGaugeChange> TclearanceGaugeChange { get; set; }
        public virtual DbSet<TclearanceGaugeType> TclearanceGaugeType { get; set; }
        public virtual DbSet<TcommonSwitchAndCrossingData> TcommonSwitchAndCrossingData { get; set; }
        public virtual DbSet<Tconcessionaire> Tconcessionaire { get; set; }
        public virtual DbSet<TconnectionData> TconnectionData { get; set; }
        public virtual DbSet<TconnectionTt> TconnectionTt { get; set; }
        public virtual DbSet<Tcontractor> Tcontractor { get; set; }
        public virtual DbSet<Tcontroller> Tcontroller { get; set; }
        public virtual DbSet<TcontrollerTechnologyType> TcontrollerTechnologyType { get; set; }
        public virtual DbSet<TcrossSection> TcrossSection { get; set; }
        public virtual DbSet<TcrossedElement> TcrossedElement { get; set; }
        public virtual DbSet<Tcrossing> Tcrossing { get; set; }
        public virtual DbSet<TcurrentCurve> TcurrentCurve { get; set; }
        public virtual DbSet<TcurrentLimitation> TcurrentLimitation { get; set; }
        public virtual DbSet<Tcurve> Tcurve { get; set; }
        public virtual DbSet<TcurveValueTable> TcurveValueTable { get; set; }
        public virtual DbSet<TcurvingLimitationType> TcurvingLimitationType { get; set; }
        public virtual DbSet<Tcustomer> Tcustomer { get; set; }
        public virtual DbSet<TdecelerationCurve> TdecelerationCurve { get; set; }
        public virtual DbSet<TdelimitedDirection> TdelimitedDirection { get; set; }
        public virtual DbSet<TdelimitedOrientedElement> TdelimitedOrientedElement { get; set; }
        public virtual DbSet<TdelimitedOrientedElementWithLength> TdelimitedOrientedElementWithLength { get; set; }
        public virtual DbSet<TderailKind> TderailKind { get; set; }
        public virtual DbSet<Tderailer> Tderailer { get; set; }
        public virtual DbSet<Tdesignator> Tdesignator { get; set; }
        public virtual DbSet<TdieselEngine> TdieselEngine { get; set; }
        public virtual DbSet<Tdoors> Tdoors { get; set; }
        public virtual DbSet<TdriversCabType> TdriversCabType { get; set; }
        public virtual DbSet<TeddyCurrentBrake> TeddyCurrentBrake { get; set; }
        public virtual DbSet<TefficiencyCurve> TefficiencyCurve { get; set; }
        public virtual DbSet<TeffortCurve> TeffortCurve { get; set; }
        public virtual DbSet<TelectricalWagonCouplerType> TelectricalWagonCouplerType { get; set; }
        public virtual DbSet<Telectrification> Telectrification { get; set; }
        public virtual DbSet<TelectrificationChange> TelectrificationChange { get; set; }
        public virtual DbSet<TelectrificationSystem> TelectrificationSystem { get; set; }
        public virtual DbSet<TelementRefInGroup> TelementRefInGroup { get; set; }
        public virtual DbSet<TelementWithIdandName> TelementWithIdandName { get; set; }
        public virtual DbSet<TelementWithIdandNameWithoutAny> TelementWithIdandNameWithoutAny { get; set; }
        public virtual DbSet<TelementWithReference> TelementWithReference { get; set; }
        public virtual DbSet<TendPositionType> TendPositionType { get; set; }
        public virtual DbSet<Tengine> Tengine { get; set; }
        public virtual DbSet<TepsgCode> TepsgCode { get; set; }
        public virtual DbSet<Tequipment> Tequipment { get; set; }
        public virtual DbSet<Tetcs> Tetcs { get; set; }
        public virtual DbSet<TetcsTt> TetcsTt { get; set; }
        public virtual DbSet<TextendedDirection> TextendedDirection { get; set; }
        public virtual DbSet<Tformation> Tformation { get; set; }
        public virtual DbSet<TformationTt> TformationTt { get; set; }
        public virtual DbSet<TfourQuadrantChopper> TfourQuadrantChopper { get; set; }
        public virtual DbSet<Tgangway> Tgangway { get; set; }
        public virtual DbSet<Tgauge> Tgauge { get; set; }
        public virtual DbSet<TgaugeChange> TgaugeChange { get; set; }
        public virtual DbSet<Tgear> Tgear { get; set; }
        public virtual DbSet<TgeoCoord> TgeoCoord { get; set; }
        public virtual DbSet<TglobalElementWithMetadata> TglobalElementWithMetadata { get; set; }
        public virtual DbSet<Tgoods> Tgoods { get; set; }
        public virtual DbSet<TgradientChange> TgradientChange { get; set; }
        public virtual DbSet<Tholiday> Tholiday { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<Tinfrastructure> Tinfrastructure { get; set; }
        public virtual DbSet<TinfrastructureManager> TinfrastructureManager { get; set; }
        public virtual DbSet<TinfrastructureVisualization> TinfrastructureVisualization { get; set; }
        public virtual DbSet<TinsulatedRailSide> TinsulatedRailSide { get; set; }
        public virtual DbSet<TinterlockingTypes> TinterlockingTypes { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<TlaxDirection> TlaxDirection { get; set; }
        public virtual DbSet<TlevelCrossing> TlevelCrossing { get; set; }
        public virtual DbSet<Tline> Tline { get; set; }
        public virtual DbSet<TlineClassification> TlineClassification { get; set; }
        public virtual DbSet<Tlink> Tlink { get; set; }
        public virtual DbSet<TloadLimitMatrixType> TloadLimitMatrixType { get; set; }
        public virtual DbSet<TloadLimitType> TloadLimitType { get; set; }
        public virtual DbSet<TloadSwitch> TloadSwitch { get; set; }
        public virtual DbSet<TlocallyControlledArea> TlocallyControlledArea { get; set; }
        public virtual DbSet<Tlocation> Tlocation { get; set; }
        public virtual DbSet<Tlock> Tlock { get; set; }
        public virtual DbSet<Tlosses> Tlosses { get; set; }
        public virtual DbSet<TmacroscopicNode> TmacroscopicNode { get; set; }
        public virtual DbSet<TmaintenanceInterval> TmaintenanceInterval { get; set; }
        public virtual DbSet<Tmanufacturer> Tmanufacturer { get; set; }
        public virtual DbSet<TmaxTrainCurrent> TmaxTrainCurrent { get; set; }
        public virtual DbSet<TmaxTrainCurrentType> TmaxTrainCurrentType { get; set; }
        public virtual DbSet<TmaxTrainCurrentValidFor> TmaxTrainCurrentValidFor { get; set; }
        public virtual DbSet<TmechanicalWagonCouplerType> TmechanicalWagonCouplerType { get; set; }
        public virtual DbSet<Tmetadata> Tmetadata { get; set; }
        public virtual DbSet<TmileageChange> TmileageChange { get; set; }
        public virtual DbSet<TmileageChangeDescr> TmileageChangeDescr { get; set; }
        public virtual DbSet<TmileageDirection> TmileageDirection { get; set; }
        public virtual DbSet<Tmonitoring> Tmonitoring { get; set; }
        public virtual DbSet<TnationalSystem> TnationalSystem { get; set; }
        public virtual DbSet<TocpAdditionalName> TocpAdditionalName { get; set; }
        public virtual DbSet<TocpArea> TocpArea { get; set; }
        public virtual DbSet<TocpCenterSide> TocpCenterSide { get; set; }
        public virtual DbSet<TocpPropEquipmentSummary> TocpPropEquipmentSummary { get; set; }
        public virtual DbSet<TocpPropOperational> TocpPropOperational { get; set; }
        public virtual DbSet<TocpPropOther> TocpPropOther { get; set; }
        public virtual DbSet<TocpPropService> TocpPropService { get; set; }
        public virtual DbSet<TocpRefInGroup> TocpRefInGroup { get; set; }
        public virtual DbSet<TocpTsi> TocpTsi { get; set; }
        public virtual DbSet<TocpTt> TocpTt { get; set; }
        public virtual DbSet<TocpTttype> TocpTttype { get; set; }
        public virtual DbSet<TocpUptime> TocpUptime { get; set; }
        public virtual DbSet<TocpWithIdandName> TocpWithIdandName { get; set; }
        public virtual DbSet<TonOff> TonOff { get; set; }
        public virtual DbSet<TopenEnd> TopenEnd { get; set; }
        public virtual DbSet<ToperatingDay> ToperatingDay { get; set; }
        public virtual DbSet<ToperatingDayDeviance> ToperatingDayDeviance { get; set; }
        public virtual DbSet<ToperatingPeriod> ToperatingPeriod { get; set; }
        public virtual DbSet<ToperatingPeriodRef> ToperatingPeriodRef { get; set; }
        public virtual DbSet<ToperationControlPoint> ToperationControlPoint { get; set; }
        public virtual DbSet<ToperationMode> ToperationMode { get; set; }
        public virtual DbSet<ToperationModeChange> ToperationModeChange { get; set; }
        public virtual DbSet<ToperationalUndertaking> ToperationalUndertaking { get; set; }
        public virtual DbSet<Toperator> Toperator { get; set; }
        public virtual DbSet<TorganizationalUnits> TorganizationalUnits { get; set; }
        public virtual DbSet<TorientedElement> TorientedElement { get; set; }
        public virtual DbSet<TorientedElementWithLength> TorientedElementWithLength { get; set; }
        public virtual DbSet<TotherEquipment> TotherEquipment { get; set; }
        public virtual DbSet<Towner> Towner { get; set; }
        public virtual DbSet<TownerChange> TownerChange { get; set; }
        public virtual DbSet<Tpantograph> Tpantograph { get; set; }
        public virtual DbSet<Tpassenger> Tpassenger { get; set; }
        public virtual DbSet<TpassengerFlowSpeed> TpassengerFlowSpeed { get; set; }
        public virtual DbSet<Tpath> Tpath { get; set; }
        public virtual DbSet<TplacedElement> TplacedElement { get; set; }
        public virtual DbSet<TplacedElementWithLength> TplacedElementWithLength { get; set; }
        public virtual DbSet<Tplaces> Tplaces { get; set; }
        public virtual DbSet<TplacesTt> TplacesTt { get; set; }
        public virtual DbSet<TplatformEdge> TplatformEdge { get; set; }
        public virtual DbSet<TplatformEdgeRef> TplatformEdgeRef { get; set; }
        public virtual DbSet<TpneumaticWagonCouplerType> TpneumaticWagonCouplerType { get; set; }
        public virtual DbSet<Tpoint> Tpoint { get; set; }
        public virtual DbSet<TposInTrack> TposInTrack { get; set; }
        public virtual DbSet<TpowerTransmission> TpowerTransmission { get; set; }
        public virtual DbSet<TpowerTransmissionChange> TpowerTransmissionChange { get; set; }
        public virtual DbSet<Tpropulsion> Tpropulsion { get; set; }
        public virtual DbSet<TrackTractionType> TrackTractionType { get; set; }
        public virtual DbSet<TradiusChange> TradiusChange { get; set; }
        public virtual DbSet<TrailNetwork> TrailNetwork { get; set; }
        public virtual DbSet<TrailwayUndertaking> TrailwayUndertaking { get; set; }
        public virtual DbSet<TrelatedPositionType> TrelatedPositionType { get; set; }
        public virtual DbSet<Trollingstock> Trollingstock { get; set; }
        public virtual DbSet<Trostering> Trostering { get; set; }
        public virtual DbSet<TruleCodeElement> TruleCodeElement { get; set; }
        public virtual DbSet<TrunTimes> TrunTimes { get; set; }
        public virtual DbSet<TsectionTt> TsectionTt { get; set; }
        public virtual DbSet<Tservice> Tservice { get; set; }
        public virtual DbSet<TserviceSection> TserviceSection { get; set; }
        public virtual DbSet<TserviceSectionRef> TserviceSectionRef { get; set; }
        public virtual DbSet<Tside> Tside { get; set; }
        public virtual DbSet<Tsignal> Tsignal { get; set; }
        public virtual DbSet<TsignalBase> TsignalBase { get; set; }
        public virtual DbSet<TsignalBraking> TsignalBraking { get; set; }
        public virtual DbSet<TsignalCatenary> TsignalCatenary { get; set; }
        public virtual DbSet<TsignalEtcs> TsignalEtcs { get; set; }
        public virtual DbSet<TsignalGroup> TsignalGroup { get; set; }
        public virtual DbSet<TsignalLevelCrossing> TsignalLevelCrossing { get; set; }
        public virtual DbSet<TsignalLine> TsignalLine { get; set; }
        public virtual DbSet<TsignalMilepost> TsignalMilepost { get; set; }
        public virtual DbSet<TsignalRefInGroup> TsignalRefInGroup { get; set; }
        public virtual DbSet<TsignalSpeed> TsignalSpeed { get; set; }
        public virtual DbSet<TsignalTrainRadio> TsignalTrainRadio { get; set; }
        public virtual DbSet<Tsize> Tsize { get; set; }
        public virtual DbSet<TspecialService> TspecialService { get; set; }
        public virtual DbSet<TspecialServiceType> TspecialServiceType { get; set; }
        public virtual DbSet<TspecificTransmissionModule> TspecificTransmissionModule { get; set; }
        public virtual DbSet<TspeedChange> TspeedChange { get; set; }
        public virtual DbSet<TspeedInfo> TspeedInfo { get; set; }
        public virtual DbSet<TspeedProfile> TspeedProfile { get; set; }
        public virtual DbSet<TspeedProfileRef> TspeedProfileRef { get; set; }
        public virtual DbSet<TspeedProfileRefRs> TspeedProfileRefRs { get; set; }
        public virtual DbSet<TspeedRangeType> TspeedRangeType { get; set; }
        public virtual DbSet<TstandardDeviationTimes> TstandardDeviationTimes { get; set; }
        public virtual DbSet<Tstate> Tstate { get; set; }
        public virtual DbSet<TstateWithLength> TstateWithLength { get; set; }
        public virtual DbSet<Tstates> Tstates { get; set; }
        public virtual DbSet<TstatesWithLength> TstatesWithLength { get; set; }
        public virtual DbSet<TstationTrackInfo> TstationTrackInfo { get; set; }
        public virtual DbSet<Tstatistic> Tstatistic { get; set; }
        public virtual DbSet<TstatisticAnalyses> TstatisticAnalyses { get; set; }
        public virtual DbSet<TstatisticTimes> TstatisticTimes { get; set; }
        public virtual DbSet<TstopActivity> TstopActivity { get; set; }
        public virtual DbSet<TstopDescription> TstopDescription { get; set; }
        public virtual DbSet<TstopPost> TstopPost { get; set; }
        public virtual DbSet<TstopTimes> TstopTimes { get; set; }
        public virtual DbSet<Tstorage> Tstorage { get; set; }
        public virtual DbSet<TstrictDirection> TstrictDirection { get; set; }
        public virtual DbSet<TstrictOrientedElement> TstrictOrientedElement { get; set; }
        public virtual DbSet<TstrictOrientedElementWithLength> TstrictOrientedElementWithLength { get; set; }
        public virtual DbSet<Tswitch> Tswitch { get; set; }
        public virtual DbSet<TswitchConnectionData> TswitchConnectionData { get; set; }
        public virtual DbSet<TtapTsiCompositIdentifierOperationalType> TtapTsiCompositIdentifierOperationalType { get; set; }
        public virtual DbSet<TtechnicalStopActivity> TtechnicalStopActivity { get; set; }
        public virtual DbSet<Ttilting> Ttilting { get; set; }
        public virtual DbSet<TtiltingActuationType> TtiltingActuationType { get; set; }
        public virtual DbSet<TtimeSpan> TtimeSpan { get; set; }
        public virtual DbSet<Ttimetable> Ttimetable { get; set; }
        public virtual DbSet<TtimetablePeriod> TtimetablePeriod { get; set; }
        public virtual DbSet<TtopologyReference> TtopologyReference { get; set; }
        public virtual DbSet<Ttrack> Ttrack { get; set; }
        public virtual DbSet<TtrackCircuitBorder> TtrackCircuitBorder { get; set; }
        public virtual DbSet<TtrackCondition> TtrackCondition { get; set; }
        public virtual DbSet<TtrackNode> TtrackNode { get; set; }
        public virtual DbSet<TtrackRef> TtrackRef { get; set; }
        public virtual DbSet<TtrackRefInGroup> TtrackRefInGroup { get; set; }
        public virtual DbSet<TtractionInverter> TtractionInverter { get; set; }
        public virtual DbSet<TtractionMotor> TtractionMotor { get; set; }
        public virtual DbSet<Ttrain> Ttrain { get; set; }
        public virtual DbSet<TtrainAlignment> TtrainAlignment { get; set; }
        public virtual DbSet<TtrainDetector> TtrainDetector { get; set; }
        public virtual DbSet<TtrainEngine> TtrainEngine { get; set; }
        public virtual DbSet<TtrainGroup> TtrainGroup { get; set; }
        public virtual DbSet<TtrainPart> TtrainPart { get; set; }
        public virtual DbSet<TtrainPartRef> TtrainPartRef { get; set; }
        public virtual DbSet<TtrainPartSequence> TtrainPartSequence { get; set; }
        public virtual DbSet<TtrainProtection> TtrainProtection { get; set; }
        public virtual DbSet<TtrainProtectionChange> TtrainProtectionChange { get; set; }
        public virtual DbSet<TtrainProtectionElement> TtrainProtectionElement { get; set; }
        public virtual DbSet<TtrainProtectionElementGroup> TtrainProtectionElementGroup { get; set; }
        public virtual DbSet<TtrainProtectionMedium> TtrainProtectionMedium { get; set; }
        public virtual DbSet<TtrainProtectionMonitoring> TtrainProtectionMonitoring { get; set; }
        public virtual DbSet<TtrainRadio> TtrainRadio { get; set; }
        public virtual DbSet<TtrainRadioAttributes> TtrainRadioAttributes { get; set; }
        public virtual DbSet<TtrainRadioChange> TtrainRadioChange { get; set; }
        public virtual DbSet<TtrainResistance> TtrainResistance { get; set; }
        public virtual DbSet<TtrainScope> TtrainScope { get; set; }
        public virtual DbSet<TtrainType> TtrainType { get; set; }
        public virtual DbSet<Ttransformer> Ttransformer { get; set; }
        public virtual DbSet<Ttunnel> Ttunnel { get; set; }
        public virtual DbSet<TuniqueTrainKey> TuniqueTrainKey { get; set; }
        public virtual DbSet<TusageType> TusageType { get; set; }
        public virtual DbSet<TvalidForMovements> TvalidForMovements { get; set; }
        public virtual DbSet<TvalueTable> TvalueTable { get; set; }
        public virtual DbSet<TvalueTableColumnHeader> TvalueTableColumnHeader { get; set; }
        public virtual DbSet<TvalueTableValueLine> TvalueTableValueLine { get; set; }
        public virtual DbSet<TvalueTableValueLineValues> TvalueTableValueLineValues { get; set; }
        public virtual DbSet<Tvehicle> Tvehicle { get; set; }
        public virtual DbSet<TvehicleIdentification> TvehicleIdentification { get; set; }
        public virtual DbSet<TvehicleManufacturer> TvehicleManufacturer { get; set; }
        public virtual DbSet<TvehicleOperator> TvehicleOperator { get; set; }
        public virtual DbSet<TvehicleRef> TvehicleRef { get; set; }
        public virtual DbSet<TverbalCounter> TverbalCounter { get; set; }
        public virtual DbSet<Twagon> Twagon { get; set; }
        public virtual DbSet<Twinding> Twinding { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QDVS6I6;Initial Catalog=XSDtoSQL;Integrated Security=True;Persist Security Info=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contributor>(entity =>
            {
                entity.Property(e => e.ContributorId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Coverage>(entity =>
            {
                entity.Property(e => e.CoverageId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Creator>(entity =>
            {
                entity.Property(e => e.CreatorId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Date>(entity =>
            {
                entity.Property(e => e.DateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Description>(entity =>
            {
                entity.Property(e => e.DescriptionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Eannotation>(entity =>
            {
                entity.ToTable("EAnnotation");

                entity.Property(e => e.EannotationId)
                    .HasColumnName("EAnnotationId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TextNavigation)
                    .WithMany(p => p.Eannotation)
                    .HasForeignKey(d => d.Text)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EAnnotation_TAnnotationText");
            });

            modelBuilder.Entity<Eannotations>(entity =>
            {
                entity.ToTable("EAnnotations");

                entity.Property(e => e.EannotationsId)
                    .HasColumnName("EAnnotationsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AnnotationNavigation)
                    .WithMany(p => p.Eannotations)
                    .HasForeignKey(d => d.Annotation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EAnnotations_EAnnotation");
            });

            modelBuilder.Entity<EarrivalDepartureTimes>(entity =>
            {
                entity.ToTable("EArrivalDepartureTimes");

                entity.Property(e => e.EarrivalDepartureTimesId)
                    .HasColumnName("EArrivalDepartureTimesId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Eattributes>(entity =>
            {
                entity.ToTable("EAttributes");

                entity.Property(e => e.EattributesId)
                    .HasColumnName("EAttributesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AttributeNavigation)
                    .WithMany(p => p.Eattributes)
                    .HasForeignKey(d => d.Attribute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EAttributes_TAttribute");
            });

            modelBuilder.Entity<EauxiliarySupply>(entity =>
            {
                entity.ToTable("EAuxiliarySupply");

                entity.Property(e => e.EauxiliarySupplyId)
                    .HasColumnName("EAuxiliarySupplyId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DedicatedSupplySystemNavigation)
                    .WithMany(p => p.EauxiliarySupply)
                    .HasForeignKey(d => d.DedicatedSupplySystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EAuxiliarySupply_TAuxiliarySupplySystem");
            });

            modelBuilder.Entity<EaxleWeightChanges>(entity =>
            {
                entity.ToTable("EAxleWeightChanges");

                entity.Property(e => e.EaxleWeightChangesId)
                    .HasColumnName("EAxleWeightChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AxleWeightChangeNavigation)
                    .WithMany(p => p.EaxleWeightChanges)
                    .HasForeignKey(d => d.AxleWeightChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EAxleWeightChanges_TAxleWeightChange");
            });

            modelBuilder.Entity<Ebalises>(entity =>
            {
                entity.ToTable("EBalises");

                entity.Property(e => e.EbalisesId)
                    .HasColumnName("EBalisesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BaliseNavigation)
                    .WithMany(p => p.Ebalises)
                    .HasForeignKey(d => d.Balise)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBalises_TBalise");

                entity.HasOne(d => d.BaliseGroupNavigation)
                    .WithMany(p => p.Ebalises)
                    .HasForeignKey(d => d.BaliseGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBalises_TBaliseGroup");
            });

            modelBuilder.Entity<Eblock>(entity =>
            {
                entity.ToTable("EBlock");

                entity.Property(e => e.EblockId)
                    .HasColumnName("EBlockId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BlockPartSequenceNavigation)
                    .WithMany(p => p.Eblock)
                    .HasForeignKey(d => d.BlockPartSequence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBlock_EBlockPartSequence");
            });

            modelBuilder.Entity<EblockPartSequence>(entity =>
            {
                entity.ToTable("EBlockPartSequence");

                entity.Property(e => e.EblockPartSequenceId)
                    .HasColumnName("EBlockPartSequenceId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BlockPartRefNavigation)
                    .WithMany(p => p.EblockPartSequence)
                    .HasForeignKey(d => d.BlockPartRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBlockPartSequence_TBlockPartRef");
            });

            modelBuilder.Entity<EblockParts>(entity =>
            {
                entity.ToTable("EBlockParts");

                entity.Property(e => e.EblockPartsId)
                    .HasColumnName("EBlockPartsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.BlockPartNavigation)
                    .WithMany(p => p.EblockParts)
                    .HasForeignKey(d => d.BlockPart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBlockParts_TBlockPart");
            });

            modelBuilder.Entity<Eblocks>(entity =>
            {
                entity.ToTable("EBlocks");

                entity.Property(e => e.EblocksId)
                    .HasColumnName("EBlocksId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BlockNavigation)
                    .WithMany(p => p.Eblocks)
                    .HasForeignKey(d => d.Block)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBlocks_EBlock");
            });

            modelBuilder.Entity<Eborder>(entity =>
            {
                entity.ToTable("EBorder");

                entity.Property(e => e.EborderId)
                    .HasColumnName("EBorderId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BorderNavigation)
                    .WithMany(p => p.Eborder)
                    .HasForeignKey(d => d.Border)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBorder_TBorder");
            });

            modelBuilder.Entity<EbrakeUsage>(entity =>
            {
                entity.ToTable("EBrakeUsage");

                entity.Property(e => e.EbrakeUsageId)
                    .HasColumnName("EBrakeUsageId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.BrakePercentage).IsRequired();

                entity.Property(e => e.EmergencyBrakePercentage).IsRequired();

                entity.Property(e => e.RegularBrakePercentage).IsRequired();
            });

            modelBuilder.Entity<Ebridge>(entity =>
            {
                entity.ToTable("EBridge");

                entity.Property(e => e.EbridgeId)
                    .HasColumnName("EBridgeId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossedElementsNavigation)
                    .WithMany(p => p.Ebridge)
                    .HasForeignKey(d => d.CrossedElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBridge_ECrossedElements");
            });

            modelBuilder.Entity<Ebridges>(entity =>
            {
                entity.ToTable("EBridges");

                entity.Property(e => e.EbridgesId)
                    .HasColumnName("EBridgesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BrigdeNavigation)
                    .WithMany(p => p.Ebridges)
                    .HasForeignKey(d => d.Brigde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EBridges_EBridge");
            });

            modelBuilder.Entity<Ecategories>(entity =>
            {
                entity.ToTable("ECategories");

                entity.Property(e => e.EcategoriesId)
                    .HasColumnName("ECategoriesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Ecategories)
                    .HasForeignKey(d => d.Category)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECategories_ECategory");
            });

            modelBuilder.Entity<Ecategory>(entity =>
            {
                entity.ToTable("ECategory");

                entity.Property(e => e.EcategoryId)
                    .HasColumnName("ECategoryId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Ecirculations>(entity =>
            {
                entity.ToTable("ECirculations");

                entity.Property(e => e.EcirculationsId)
                    .HasColumnName("ECirculationsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CirculationNavigation)
                    .WithMany(p => p.Ecirculations)
                    .HasForeignKey(d => d.Circulation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECirculations_TCirculation");
            });

            modelBuilder.Entity<Eclassification>(entity =>
            {
                entity.ToTable("EClassification");

                entity.Property(e => e.EclassificationId)
                    .HasColumnName("EClassificationId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ManufacturerNavigation)
                    .WithMany(p => p.Eclassification)
                    .HasForeignKey(d => d.Manufacturer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EClassification_TManufacturer");

                entity.HasOne(d => d.OperatorNavigation)
                    .WithMany(p => p.Eclassification)
                    .HasForeignKey(d => d.Operator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EClassification_EOperator");
            });

            modelBuilder.Entity<EclearanceGaugeChanges>(entity =>
            {
                entity.ToTable("EClearanceGaugeChanges");

                entity.Property(e => e.EclearanceGaugeChangesId)
                    .HasColumnName("EClearanceGaugeChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ClearanceGaugeChangeNavigation)
                    .WithMany(p => p.EclearanceGaugeChanges)
                    .HasForeignKey(d => d.ClearanceGaugeChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EClearanceGaugeChanges_TClearanceGaugeChange");
            });

            modelBuilder.Entity<EconnectionTt>(entity =>
            {
                entity.ToTable("EConnectionTT");

                entity.Property(e => e.EconnectionTtid)
                    .HasColumnName("EConnectionTTId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AnnotationRefNavigation)
                    .WithMany(p => p.EconnectionTt)
                    .HasForeignKey(d => d.AnnotationRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EConnectionTT_TAnnotationRef");

                entity.HasOne(d => d.ExternalReferenceNavigation)
                    .WithMany(p => p.EconnectionTt)
                    .HasForeignKey(d => d.ExternalReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EConnectionTT_EExternalReference");
            });

            modelBuilder.Entity<Econnections>(entity =>
            {
                entity.ToTable("EConnections");

                entity.Property(e => e.EconnectionsId)
                    .HasColumnName("EConnectionsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossingNavigation)
                    .WithMany(p => p.Econnections)
                    .HasForeignKey(d => d.Crossing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EConnections_ECrossing");

                entity.HasOne(d => d.SwitchNavigation)
                    .WithMany(p => p.Econnections)
                    .HasForeignKey(d => d.Switch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EConnections_ESwitch");
            });

            modelBuilder.Entity<EconnectionsTt>(entity =>
            {
                entity.ToTable("EConnectionsTT");

                entity.Property(e => e.EconnectionsTtid)
                    .HasColumnName("EConnectionsTTId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ConnectionNavigation)
                    .WithMany(p => p.EconnectionsTt)
                    .HasForeignKey(d => d.Connection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EConnectionsTT_EConnectionTT");
            });

            modelBuilder.Entity<Econtrollers>(entity =>
            {
                entity.ToTable("EControllers");

                entity.Property(e => e.EcontrollersId)
                    .HasColumnName("EControllersId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ControllerNavigation)
                    .WithMany(p => p.Econtrollers)
                    .HasForeignKey(d => d.Controller)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EControllers_TController");
            });

            modelBuilder.Entity<Ecouplers>(entity =>
            {
                entity.ToTable("ECouplers");

                entity.Property(e => e.EcouplersId)
                    .HasColumnName("ECouplersId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ElectricalCouplerNavigation)
                    .WithMany(p => p.Ecouplers)
                    .HasForeignKey(d => d.ElectricalCoupler)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECouplers_EElectricalCoupler");

                entity.HasOne(d => d.MechanicalCouplerNavigation)
                    .WithMany(p => p.Ecouplers)
                    .HasForeignKey(d => d.MechanicalCoupler)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECouplers_EMechanicalCoupler");

                entity.HasOne(d => d.PneumaticCouplerNavigation)
                    .WithMany(p => p.Ecouplers)
                    .HasForeignKey(d => d.PneumaticCoupler)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECouplers_EPneumaticCoupler");
            });

            modelBuilder.Entity<EcrossSections>(entity =>
            {
                entity.ToTable("ECrossSections");

                entity.Property(e => e.EcrossSectionsId)
                    .HasColumnName("ECrossSectionsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossSectionNavigation)
                    .WithMany(p => p.EcrossSections)
                    .HasForeignKey(d => d.CrossSection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECrossSections_TCrossSection");
            });

            modelBuilder.Entity<EcrossedElements>(entity =>
            {
                entity.ToTable("ECrossedElements");

                entity.Property(e => e.EcrossedElementsId)
                    .HasColumnName("ECrossedElementsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossedElementNavigation)
                    .WithMany(p => p.EcrossedElements)
                    .HasForeignKey(d => d.CrossedElement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECrossedElements_TCrossedElement");
            });

            modelBuilder.Entity<Ecrossing>(entity =>
            {
                entity.ToTable("ECrossing");

                entity.Property(e => e.EcrossingId)
                    .HasColumnName("ECrossingId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ConnectionNavigation)
                    .WithMany(p => p.Ecrossing)
                    .HasForeignKey(d => d.Connection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ECrossing_TSwitchConnectionData");
            });

            modelBuilder.Entity<EcurvingLimitation>(entity =>
            {
                entity.ToTable("ECurvingLimitation");

                entity.Property(e => e.EcurvingLimitationId)
                    .HasColumnName("ECurvingLimitationId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Ederailers>(entity =>
            {
                entity.ToTable("EDerailers");

                entity.Property(e => e.EderailersId)
                    .HasColumnName("EDerailersId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DerailerNavigation)
                    .WithMany(p => p.Ederailers)
                    .HasForeignKey(d => d.Derailer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDerailers_TDerailer");
            });

            modelBuilder.Entity<Edoors>(entity =>
            {
                entity.ToTable("EDoors");

                entity.Property(e => e.EdoorsId)
                    .HasColumnName("EDoorsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PassengerFlowSpeedNavigation)
                    .WithMany(p => p.Edoors)
                    .HasForeignKey(d => d.PassengerFlowSpeed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDoors_TPassengerFlowSpeed");
            });

            modelBuilder.Entity<EelectricalCoupler>(entity =>
            {
                entity.ToTable("EElectricalCoupler");

                entity.Property(e => e.EelectricalCouplerId)
                    .HasColumnName("EElectricalCouplerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EelectrificationChanges>(entity =>
            {
                entity.ToTable("EElectrificationChanges");

                entity.Property(e => e.EelectrificationChangesId)
                    .HasColumnName("EElectrificationChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ElectrificationChangeNavigation)
                    .WithMany(p => p.EelectrificationChanges)
                    .HasForeignKey(d => d.ElectrificationChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EElectrificationChanges_TElectrificationChange");
            });

            modelBuilder.Entity<Eengine>(entity =>
            {
                entity.ToTable("EEngine");

                entity.Property(e => e.EengineId)
                    .HasColumnName("EEngineId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EnergyStorageNavigation)
                    .WithMany(p => p.Eengine)
                    .HasForeignKey(d => d.EnergyStorage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEngine_EStorage");

                entity.HasOne(d => d.MonitoringNavigation)
                    .WithMany(p => p.Eengine)
                    .HasForeignKey(d => d.Monitoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEngine_EMonitoring");

                entity.HasOne(d => d.PantographNavigation)
                    .WithMany(p => p.Eengine)
                    .HasForeignKey(d => d.Pantograph)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEngine_EPantograph");

                entity.HasOne(d => d.PropulsionNavigation)
                    .WithMany(p => p.Eengine)
                    .HasForeignKey(d => d.Propulsion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEngine_EPropulsion");
            });

            modelBuilder.Entity<Eequipment>(entity =>
            {
                entity.ToTable("EEquipment");

                entity.Property(e => e.EequipmentId)
                    .HasColumnName("EEquipmentId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EtcsNavigation)
                    .WithMany(p => p.Eequipment)
                    .HasForeignKey(d => d.Etcs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEquipment_TEtcsTT");
            });

            modelBuilder.Entity<EequipmentUsage>(entity =>
            {
                entity.ToTable("EEquipmentUsage");

                entity.Property(e => e.EequipmentUsageId)
                    .HasColumnName("EEquipmentUsageId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EquipmentNavigation)
                    .WithMany(p => p.EequipmentUsage)
                    .HasForeignKey(d => d.Equipment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EEquipmentUsage_EEquipment");
            });

            modelBuilder.Entity<Eetcs>(entity =>
            {
                entity.ToTable("EETCS");

                entity.Property(e => e.Eetcsid)
                    .HasColumnName("EETCSId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SpecificTransmissionModuleNavigation)
                    .WithMany(p => p.Eetcs)
                    .HasForeignKey(d => d.SpecificTransmissionModule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EETCS_TSpecificTransmissionModule");
            });

            modelBuilder.Entity<EexternalReference>(entity =>
            {
                entity.ToTable("EExternalReference");

                entity.Property(e => e.EexternalReferenceId)
                    .HasColumnName("EExternalReferenceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TafTapTsiTrainId).HasColumnName("TafTapTsiTrainID");

                entity.HasOne(d => d.InformationNavigation)
                    .WithMany(p => p.EexternalReference)
                    .HasForeignKey(d => d.Information)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EExternalReference_EExternalReferenceInformation");

                entity.HasOne(d => d.LineNumberNavigation)
                    .WithMany(p => p.EexternalReference)
                    .HasForeignKey(d => d.LineNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EExternalReference_EExternalReferenceLineNumber");

                entity.HasOne(d => d.TafTapTsiTrain)
                    .WithMany(p => p.EexternalReference)
                    .HasForeignKey(d => d.TafTapTsiTrainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EExternalReference_ETapTsiTransportOperationalIdentifier");

                entity.HasOne(d => d.TrainNumberNavigation)
                    .WithMany(p => p.EexternalReference)
                    .HasForeignKey(d => d.TrainNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EExternalReference_EExternalReferenceTrainNumber");
            });

            modelBuilder.Entity<EexternalReferenceInformation>(entity =>
            {
                entity.ToTable("EExternalReferenceInformation");

                entity.Property(e => e.EexternalReferenceInformationId)
                    .HasColumnName("EExternalReferenceInformationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<EexternalReferenceLineNumber>(entity =>
            {
                entity.ToTable("EExternalReferenceLineNumber");

                entity.Property(e => e.EexternalReferenceLineNumberId)
                    .HasColumnName("EExternalReferenceLineNumberId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LineNumber).IsRequired();
            });

            modelBuilder.Entity<EexternalReferenceTrainNumber>(entity =>
            {
                entity.ToTable("EExternalReferenceTrainNumber");

                entity.Property(e => e.EexternalReferenceTrainNumberId)
                    .HasColumnName("EExternalReferenceTrainNumberId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrainNumber).IsRequired();

                entity.HasOne(d => d.OrganizationalUnitBindingNavigation)
                    .WithMany(p => p.EexternalReferenceTrainNumber)
                    .HasForeignKey(d => d.OrganizationalUnitBinding)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EExternalReferenceTrainNumber_EOrganizationalUnitBinding");
            });

            modelBuilder.Entity<Eformation>(entity =>
            {
                entity.ToTable("EFormation");

                entity.Property(e => e.EformationId)
                    .HasColumnName("EFormationId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CategoryRefNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.CategoryRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TElementWithReference");

                entity.HasOne(d => d.SpeedProfileRefNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.SpeedProfileRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TSpeedProfileRefRS");

                entity.HasOne(d => d.TechnicalStopActivityNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TechnicalStopActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TTechnicalStopActivity");

                entity.HasOne(d => d.TrainBrakeOperationNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TrainBrakeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TBasicBrakeOperation");

                entity.HasOne(d => d.TrainBrakesNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TrainBrakes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TBasicBrakeType");

                entity.HasOne(d => d.TrainEngineNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TrainEngine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TTrainEngine");

                entity.HasOne(d => d.TrainOrderNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TrainOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_ETrainOrder");

                entity.HasOne(d => d.TrainResistanceNavigation)
                    .WithMany(p => p.Eformation)
                    .HasForeignKey(d => d.TrainResistance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormation_TTrainResistance");
            });

            modelBuilder.Entity<EformationTt>(entity =>
            {
                entity.ToTable("EFormationTT");

                entity.Property(e => e.EformationTtid)
                    .HasColumnName("EFormationTTId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EquipmentUsageNavigation)
                    .WithMany(p => p.EformationTt)
                    .HasForeignKey(d => d.EquipmentUsage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormationTT_EEquipmentUsage");

                entity.HasOne(d => d.PassengerUsageNavigation)
                    .WithMany(p => p.EformationTt)
                    .HasForeignKey(d => d.PassengerUsage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormationTT_EPassengerFacilityTT");

                entity.HasOne(d => d.ReservationInfoNavigation)
                    .WithMany(p => p.EformationTt)
                    .HasForeignKey(d => d.ReservationInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormationTT_EReservationInfo");
            });

            modelBuilder.Entity<Eformations>(entity =>
            {
                entity.ToTable("EFormations");

                entity.Property(e => e.EformationsId)
                    .HasColumnName("EFormationsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.FormationNavigation)
                    .WithMany(p => p.Eformations)
                    .HasForeignKey(d => d.Formation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFormations_EFormation");
            });

            modelBuilder.Entity<EfourQuadrantChopper>(entity =>
            {
                entity.ToTable("EFourQuadrantChopper");

                entity.Property(e => e.EfourQuadrantChopperId)
                    .HasColumnName("EFourQuadrantChopperId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.EfourQuadrantChopper)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFourQuadrantChopper_TEfficiencyCurve");

                entity.HasOne(d => d.PhiNavigation)
                    .WithMany(p => p.EfourQuadrantChopper)
                    .HasForeignKey(d => d.Phi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EFourQuadrantChopper_TCurve");
            });

            modelBuilder.Entity<EgaugeChanges>(entity =>
            {
                entity.ToTable("EGaugeChanges");

                entity.Property(e => e.EgaugeChangesId)
                    .HasColumnName("EGaugeChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.GaugeChangeNavigation)
                    .WithMany(p => p.EgaugeChanges)
                    .HasForeignKey(d => d.GaugeChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGaugeChanges_TGaugeChange");
            });

            modelBuilder.Entity<Egear>(entity =>
            {
                entity.ToTable("EGear");

                entity.Property(e => e.EgearId)
                    .HasColumnName("EGearId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.Egear)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGear_TEfficiencyCurve");
            });

            modelBuilder.Entity<EgeneralInfraAttribute>(entity =>
            {
                entity.ToTable("EGeneralInfraAttribute");

                entity.Property(e => e.EgeneralInfraAttributeId)
                    .HasColumnName("EGeneralInfraAttributeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.AttributesNavigation)
                    .WithMany(p => p.EgeneralInfraAttribute)
                    .HasForeignKey(d => d.Attributes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGeneralInfraAttribute_EAttributes");
            });

            modelBuilder.Entity<EgeneralInfraAttributes>(entity =>
            {
                entity.ToTable("EGeneralInfraAttributes");

                entity.Property(e => e.EgeneralInfraAttributesId)
                    .HasColumnName("EGeneralInfraAttributesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.GeneralInfraAttributeNavigation)
                    .WithMany(p => p.EgeneralInfraAttributes)
                    .HasForeignKey(d => d.GeneralInfraAttribute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGeneralInfraAttributes_EGeneralInfraAttribute");
            });

            modelBuilder.Entity<EgeoMappings>(entity =>
            {
                entity.ToTable("EGeoMappings");

                entity.Property(e => e.EgeoMappingsId)
                    .HasColumnName("EGeoMappingsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.GeoMappingNavigation)
                    .WithMany(p => p.EgeoMappings)
                    .HasForeignKey(d => d.GeoMapping)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGeoMappings_TPlacedElement");
            });

            modelBuilder.Entity<Egoods>(entity =>
            {
                entity.ToTable("EGoods");

                entity.Property(e => e.EgoodsId)
                    .HasColumnName("EGoodsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ServiceNavigation)
                    .WithMany(p => p.Egoods)
                    .HasForeignKey(d => d.Service)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGoods_TService");
            });

            modelBuilder.Entity<EgradientChanges>(entity =>
            {
                entity.ToTable("EGradientChanges");

                entity.Property(e => e.EgradientChangesId)
                    .HasColumnName("EGradientChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.GradientChangeNavigation)
                    .WithMany(p => p.EgradientChanges)
                    .HasForeignKey(d => d.GradientChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EGradientChanges_TGradientChange");
            });

            modelBuilder.Entity<Eholidays>(entity =>
            {
                entity.ToTable("EHolidays");

                entity.Property(e => e.EholidaysId)
                    .HasColumnName("EHolidaysId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.HolidayNavigation)
                    .WithMany(p => p.Eholidays)
                    .HasForeignKey(d => d.Holiday)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EHolidays_THoliday");
            });

            modelBuilder.Entity<EinfraAttr>(entity =>
            {
                entity.ToTable("EInfraAttr");

                entity.Property(e => e.EinfraAttrId)
                    .HasColumnName("EInfraAttrId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AxleWeightNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.AxleWeight)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TAxleWeight");

                entity.HasOne(d => d.ClearanceGaugeNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.ClearanceGauge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TClearanceGaugeType");

                entity.HasOne(d => d.ElectrificationNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.Electrification)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TElectrification");

                entity.HasOne(d => d.EpsgCodeNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.EpsgCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TEpsgCode");

                entity.HasOne(d => d.GaugeNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.Gauge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TGauge");

                entity.HasOne(d => d.GeneralInfraAttributesNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.GeneralInfraAttributes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_EGeneralInfraAttributes");

                entity.HasOne(d => d.OperationModeNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.OperationMode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TOperationMode");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.Owner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TOwner");

                entity.HasOne(d => d.PowerTransmissionNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.PowerTransmission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TPowerTransmission");

                entity.HasOne(d => d.SpeedsNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.Speeds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_ESpeeds");

                entity.HasOne(d => d.TrainProtectionNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.TrainProtection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TTrainProtection");

                entity.HasOne(d => d.TrainRadioNavigation)
                    .WithMany(p => p.EinfraAttr)
                    .HasForeignKey(d => d.TrainRadio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttr_TTrainRadioAttributes");
            });

            modelBuilder.Entity<EinfraAttrGroup>(entity =>
            {
                entity.ToTable("EInfraAttrGroup");

                entity.Property(e => e.EinfraAttrGroupId)
                    .HasColumnName("EInfraAttrGroupId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.InfraAttributesNavigation)
                    .WithMany(p => p.EinfraAttrGroup)
                    .HasForeignKey(d => d.InfraAttributes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttrGroup_EInfraAttr");
            });

            modelBuilder.Entity<EinfraAttrGroupRefs>(entity =>
            {
                entity.ToTable("EInfraAttrGroupRefs");

                entity.Property(e => e.EinfraAttrGroupRefsId)
                    .HasColumnName("EInfraAttrGroupRefsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.InfraAttrGroupRefNavigation)
                    .WithMany(p => p.EinfraAttrGroupRefs)
                    .HasForeignKey(d => d.InfraAttrGroupRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfraAttrGroupRefs_TElementWithReference");
            });

            modelBuilder.Entity<EinfrastructureVisualization>(entity =>
            {
                entity.ToTable("EInfrastructureVisualization");

                entity.Property(e => e.EinfrastructureVisualizationId)
                    .HasColumnName("EInfrastructureVisualizationId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LineVisNavigation)
                    .WithMany(p => p.EinfrastructureVisualization)
                    .HasForeignKey(d => d.LineVis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfrastructureVisualization_ELineVis");

                entity.HasOne(d => d.OcpVisNavigation)
                    .WithMany(p => p.EinfrastructureVisualization)
                    .HasForeignKey(d => d.OcpVis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EInfrastructureVisualization_EOcpVis");
            });

            modelBuilder.Entity<ElementContainer>(entity =>
            {
                entity.Property(e => e.ElementContainerId).ValueGeneratedNever();

                entity.HasOne(d => d.AnyNavigation)
                    .WithMany(p => p.ElementContainer)
                    .HasForeignKey(d => d.Any)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ElementContainer_SimpleLiteral");
            });

            modelBuilder.Entity<ElevelCrossing>(entity =>
            {
                entity.ToTable("ELevelCrossing");

                entity.Property(e => e.ElevelCrossingId)
                    .HasColumnName("ELevelCrossingId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossedElementsNavigation)
                    .WithMany(p => p.ElevelCrossing)
                    .HasForeignKey(d => d.CrossedElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELevelCrossing_ECrossedElements");
            });

            modelBuilder.Entity<ElevelCrossings>(entity =>
            {
                entity.ToTable("ELevelCrossings");

                entity.Property(e => e.ElevelCrossingsId)
                    .HasColumnName("ELevelCrossingsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LevelCrossingNavigation)
                    .WithMany(p => p.ElevelCrossings)
                    .HasForeignKey(d => d.LevelCrossing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELevelCrossings_ELevelCrossing");
            });

            modelBuilder.Entity<Eline>(entity =>
            {
                entity.ToTable("ELine");

                entity.Property(e => e.ElineId)
                    .HasColumnName("ELineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LineDescr).IsRequired();

                entity.HasOne(d => d.TrackRefNavigation)
                    .WithMany(p => p.Eline)
                    .HasForeignKey(d => d.TrackRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELine_TTrackRefInGroup");
            });

            modelBuilder.Entity<ElineVis>(entity =>
            {
                entity.ToTable("ELineVis");

                entity.Property(e => e.ElineVisId)
                    .HasColumnName("ELineVisId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrackVisNavigation)
                    .WithMany(p => p.ElineVis)
                    .HasForeignKey(d => d.TrackVis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELineVis_ETrackVis");
            });

            modelBuilder.Entity<EloadLimit>(entity =>
            {
                entity.ToTable("ELoadLimit");

                entity.Property(e => e.EloadLimitId)
                    .HasColumnName("ELoadLimitId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LineClassificationNavigation)
                    .WithMany(p => p.EloadLimit)
                    .HasForeignKey(d => d.LineClassification)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELoadLimit_TLineClassification");

                entity.HasOne(d => d.RailNetworkNavigation)
                    .WithMany(p => p.EloadLimit)
                    .HasForeignKey(d => d.RailNetwork)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELoadLimit_TRailNetwork");
            });

            modelBuilder.Entity<EloadLimitMatrix>(entity =>
            {
                entity.ToTable("ELoadLimitMatrix");

                entity.Property(e => e.EloadLimitMatrixId)
                    .HasColumnName("ELoadLimitMatrixId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LoadLimitNavigation)
                    .WithMany(p => p.EloadLimitMatrix)
                    .HasForeignKey(d => d.LoadLimit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELoadLimitMatrix_ELoadLimit");
            });

            modelBuilder.Entity<ElocallyControlledArea>(entity =>
            {
                entity.ToTable("ELocallyControlledArea");

                entity.Property(e => e.ElocallyControlledAreaId)
                    .HasColumnName("ELocallyControlledAreaId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ControllerRefNavigation)
                    .WithMany(p => p.ElocallyControlledArea)
                    .HasForeignKey(d => d.ControllerRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELocallyControlledArea_TElementRefInGroup");

                entity.HasOne(d => d.TrackRefNavigation)
                    .WithMany(p => p.ElocallyControlledArea)
                    .HasForeignKey(d => d.TrackRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELocallyControlledArea_TTrackRefInGroup");
            });

            modelBuilder.Entity<Elocks>(entity =>
            {
                entity.ToTable("ELocks");

                entity.Property(e => e.ElocksId)
                    .HasColumnName("ELocksId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.LockNavigation)
                    .WithMany(p => p.Elocks)
                    .HasForeignKey(d => d.Lock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ELocks_TLock");
            });

            modelBuilder.Entity<EmaintenanceIntervals>(entity =>
            {
                entity.ToTable("EMaintenanceIntervals");

                entity.Property(e => e.EmaintenanceIntervalsId)
                    .HasColumnName("EMaintenanceIntervalsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MaintenanceIntervalNavigation)
                    .WithMany(p => p.EmaintenanceIntervals)
                    .HasForeignKey(d => d.MaintenanceInterval)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMaintenanceIntervals_TMaintenanceInterval");
            });

            modelBuilder.Entity<EmechanicalCoupler>(entity =>
            {
                entity.ToTable("EMechanicalCoupler");

                entity.Property(e => e.EmechanicalCouplerId)
                    .HasColumnName("EMechanicalCouplerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EmileageChanges>(entity =>
            {
                entity.ToTable("EMileageChanges");

                entity.Property(e => e.EmileageChangesId)
                    .HasColumnName("EMileageChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MileageChangeNavigation)
                    .WithMany(p => p.EmileageChanges)
                    .HasForeignKey(d => d.MileageChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMileageChanges_TMileageChange");
            });

            modelBuilder.Entity<Emonitoring>(entity =>
            {
                entity.ToTable("EMonitoring");

                entity.Property(e => e.EmonitoringId)
                    .HasColumnName("EMonitoringId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EtcsNavigation)
                    .WithMany(p => p.Emonitoring)
                    .HasForeignKey(d => d.Etcs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMonitoring_EETCS");

                entity.HasOne(d => d.NationalSystemNavigation)
                    .WithMany(p => p.Emonitoring)
                    .HasForeignKey(d => d.NationalSystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMonitoring_TNationalSystem");

                entity.HasOne(d => d.OtherEquipmentNavigation)
                    .WithMany(p => p.Emonitoring)
                    .HasForeignKey(d => d.OtherEquipment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMonitoring_TOtherEquipment");

                entity.HasOne(d => d.TrainRadioNavigation)
                    .WithMany(p => p.Emonitoring)
                    .HasForeignKey(d => d.TrainRadio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EMonitoring_ETrainRadio");
            });

            modelBuilder.Entity<Eocp>(entity =>
            {
                entity.ToTable("EOcp");

                entity.Property(e => e.EocpId)
                    .HasColumnName("EOcpId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_TOcpArea");

                entity.HasOne(d => d.DesignatorNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.Designator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_TDesignator");

                entity.HasOne(d => d.GeoCoordNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.GeoCoord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_TGeoCoord");

                entity.HasOne(d => d.PropEquipmentNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.PropEquipment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_EOcpPropEquipment");

                entity.HasOne(d => d.PropOperationalNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.PropOperational)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_EOcpPropOperational");

                entity.HasOne(d => d.PropOtherNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.PropOther)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_EOcpPropOther");

                entity.HasOne(d => d.PropServiceNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.PropService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_TOcpPropService");

                entity.HasOne(d => d.TsiNavigation)
                    .WithMany(p => p.Eocp)
                    .HasForeignKey(d => d.Tsi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcp_TOcpTsi");
            });

            modelBuilder.Entity<EocpPropEquipment>(entity =>
            {
                entity.ToTable("EOcpPropEquipment");

                entity.Property(e => e.EocpPropEquipmentId)
                    .HasColumnName("EOcpPropEquipmentId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SummaryNavigation)
                    .WithMany(p => p.EocpPropEquipment)
                    .HasForeignKey(d => d.Summary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpPropEquipment_TOcpPropEquipmentSummary");

                entity.HasOne(d => d.TrackRefNavigation)
                    .WithMany(p => p.EocpPropEquipment)
                    .HasForeignKey(d => d.TrackRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpPropEquipment_TTrackRefInGroup");
            });

            modelBuilder.Entity<EocpPropOperational>(entity =>
            {
                entity.ToTable("EOcpPropOperational");

                entity.Property(e => e.EocpPropOperationalId)
                    .HasColumnName("EOcpPropOperationalId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.UptimeNavigation)
                    .WithMany(p => p.EocpPropOperational)
                    .HasForeignKey(d => d.Uptime)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpPropOperational_TOcpUptime");
            });

            modelBuilder.Entity<EocpPropOther>(entity =>
            {
                entity.ToTable("EOcpPropOther");

                entity.Property(e => e.EocpPropOtherId)
                    .HasColumnName("EOcpPropOtherId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AdditionalNameNavigation)
                    .WithMany(p => p.EocpPropOther)
                    .HasForeignKey(d => d.AdditionalName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpPropOther_TOcpAdditionalName");

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.EocpPropOther)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpPropOther_TStates");
            });

            modelBuilder.Entity<EocpTt>(entity =>
            {
                entity.ToTable("EOcpTT");

                entity.Property(e => e.EocpTtid)
                    .HasColumnName("EOcpTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SectionTt).HasColumnName("SectionTT");

                entity.HasOne(d => d.ConnectionsNavigation)
                    .WithMany(p => p.EocpTt)
                    .HasForeignKey(d => d.Connections)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpTT_EConnectionsTT");

                entity.HasOne(d => d.SectionTtNavigation)
                    .WithMany(p => p.EocpTt)
                    .HasForeignKey(d => d.SectionTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpTT_ESectionTT");

                entity.HasOne(d => d.StatisticsNavigation)
                    .WithMany(p => p.EocpTt)
                    .HasForeignKey(d => d.Statistics)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpTT_EStatistics");

                entity.HasOne(d => d.StopDescriptionNavigation)
                    .WithMany(p => p.EocpTt)
                    .HasForeignKey(d => d.StopDescription)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpTT_EStopDescription");

                entity.HasOne(d => d.TimesNavigation)
                    .WithMany(p => p.EocpTt)
                    .HasForeignKey(d => d.Times)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpTT_EArrivalDepartureTimes");
            });

            modelBuilder.Entity<EocpVis>(entity =>
            {
                entity.ToTable("EOcpVis");

                entity.Property(e => e.EocpVisId)
                    .HasColumnName("EOcpVisId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.EocpVis)
                    .HasForeignKey(d => d.Position)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpVis_TPoint");

                entity.HasOne(d => d.SizeNavigation)
                    .WithMany(p => p.EocpVis)
                    .HasForeignKey(d => d.Size)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpVis_TSize");
            });

            modelBuilder.Entity<EocpsTt>(entity =>
            {
                entity.ToTable("EOcpsTT");

                entity.Property(e => e.EocpsTtid)
                    .HasColumnName("EOcpsTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OcpTt).HasColumnName("OcpTT");

                entity.HasOne(d => d.OcpTtNavigation)
                    .WithMany(p => p.EocpsTt)
                    .HasForeignKey(d => d.OcpTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcpsTT_EOcpTT");
            });

            modelBuilder.Entity<EocsElements>(entity =>
            {
                entity.ToTable("EOcsElements");

                entity.Property(e => e.EocsElementsId)
                    .HasColumnName("EOcsElementsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.BalisesNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.Balises)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_EBalises");

                entity.HasOne(d => d.DerailersNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.Derailers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_EDerailers");

                entity.HasOne(d => d.LocksNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.Locks)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_ELocks");

                entity.HasOne(d => d.SignalsNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.Signals)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_ESignals");

                entity.HasOne(d => d.StopPostsNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.StopPosts)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_EStopPosts");

                entity.HasOne(d => d.TrainDetectionElementsNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.TrainDetectionElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_ETrainDetectionElements");

                entity.HasOne(d => d.TrainProtectionElementsNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.TrainProtectionElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_ETrainProtectionElements");

                entity.HasOne(d => d.TrainRadioChangesNavigation)
                    .WithMany(p => p.EocsElements)
                    .HasForeignKey(d => d.TrainRadioChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOcsElements_ETrainRadioChanges");
            });

            modelBuilder.Entity<EoperatingDay>(entity =>
            {
                entity.ToTable("EOperatingDay");

                entity.Property(e => e.EoperatingDayId)
                    .HasColumnName("EOperatingDayId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OperatingDayDevianceNavigation)
                    .WithMany(p => p.EoperatingDay)
                    .HasForeignKey(d => d.OperatingDayDeviance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperatingDay_TOperatingDayDeviance");
            });

            modelBuilder.Entity<EoperatingPeriod>(entity =>
            {
                entity.ToTable("EOperatingPeriod");

                entity.Property(e => e.EoperatingPeriodId)
                    .HasColumnName("EOperatingPeriodId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OperatingDayNavigation)
                    .WithMany(p => p.EoperatingPeriod)
                    .HasForeignKey(d => d.OperatingDay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperatingPeriod_EOperatingDay");

                entity.HasOne(d => d.SpecialServiceNavigation)
                    .WithMany(p => p.EoperatingPeriod)
                    .HasForeignKey(d => d.SpecialService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperatingPeriod_TSpecialService");
            });

            modelBuilder.Entity<EoperatingPeriodRef>(entity =>
            {
                entity.ToTable("EOperatingPeriodRef");

                entity.Property(e => e.EoperatingPeriodRefId)
                    .HasColumnName("EOperatingPeriodRefId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SpecialServiceNavigation)
                    .WithMany(p => p.EoperatingPeriodRef)
                    .HasForeignKey(d => d.SpecialService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperatingPeriodRef_TSpecialService");
            });

            modelBuilder.Entity<EoperatingPeriods>(entity =>
            {
                entity.ToTable("EOperatingPeriods");

                entity.Property(e => e.EoperatingPeriodsId)
                    .HasColumnName("EOperatingPeriodsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OperatingPeriodNavigation)
                    .WithMany(p => p.EoperatingPeriods)
                    .HasForeignKey(d => d.OperatingPeriod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperatingPeriods_EOperatingPeriod");
            });

            modelBuilder.Entity<EoperationControlPoints>(entity =>
            {
                entity.ToTable("EOperationControlPoints");

                entity.Property(e => e.EoperationControlPointsId)
                    .HasColumnName("EOperationControlPointsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OcpNavigation)
                    .WithMany(p => p.EoperationControlPoints)
                    .HasForeignKey(d => d.Ocp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperationControlPoints_EOcp");
            });

            modelBuilder.Entity<EoperationModeChanges>(entity =>
            {
                entity.ToTable("EOperationModeChanges");

                entity.Property(e => e.EoperationModeChangesId)
                    .HasColumnName("EOperationModeChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OperationModeChangeNavigation)
                    .WithMany(p => p.EoperationModeChanges)
                    .HasForeignKey(d => d.OperationModeChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperationModeChanges_TOperationModeChange");
            });

            modelBuilder.Entity<Eoperator>(entity =>
            {
                entity.ToTable("EOperator");

                entity.Property(e => e.EoperatorId)
                    .HasColumnName("EOperatorId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.VehicleIdentificationNavigation)
                    .WithMany(p => p.Eoperator)
                    .HasForeignKey(d => d.VehicleIdentification)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOperator_TVehicleIdentification");
            });

            modelBuilder.Entity<EorganizationalUnitBinding>(entity =>
            {
                entity.ToTable("EOrganizationalUnitBinding");

                entity.Property(e => e.EorganizationalUnitBindingId)
                    .HasColumnName("EOrganizationalUnitBindingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.VehicleOperatorNavigation)
                    .WithMany(p => p.EorganizationalUnitBinding)
                    .HasForeignKey(d => d.VehicleOperator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOrganizationalUnitBinding_TElementWithReference");
            });

            modelBuilder.Entity<EownerChanges>(entity =>
            {
                entity.ToTable("EOwnerChanges");

                entity.Property(e => e.EownerChangesId)
                    .HasColumnName("EOwnerChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OwnerChangeNavigation)
                    .WithMany(p => p.EownerChanges)
                    .HasForeignKey(d => d.OwnerChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOwnerChanges_TOwnerChange");
            });

            modelBuilder.Entity<Epantograph>(entity =>
            {
                entity.ToTable("EPantograph");

                entity.Property(e => e.EpantographId)
                    .HasColumnName("EPantographId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DedicatedSupplySystemNavigation)
                    .WithMany(p => p.Epantograph)
                    .HasForeignKey(d => d.DedicatedSupplySystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPantograph_TElectrificationSystem");
            });

            modelBuilder.Entity<Epassenger>(entity =>
            {
                entity.ToTable("EPassenger");

                entity.Property(e => e.EpassengerId)
                    .HasColumnName("EPassengerId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoorsNavigation)
                    .WithMany(p => p.Epassenger)
                    .HasForeignKey(d => d.Doors)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassenger_EDoors");

                entity.HasOne(d => d.GangwayNavigation)
                    .WithMany(p => p.Epassenger)
                    .HasForeignKey(d => d.Gangway)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassenger_TGangway");

                entity.HasOne(d => d.TiltingNavigation)
                    .WithMany(p => p.Epassenger)
                    .HasForeignKey(d => d.Tilting)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassenger_TTilting");
            });

            modelBuilder.Entity<EpassengerFacility>(entity =>
            {
                entity.ToTable("EPassengerFacility");

                entity.Property(e => e.EpassengerFacilityId)
                    .HasColumnName("EPassengerFacilityId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PlacesNavigation)
                    .WithMany(p => p.EpassengerFacility)
                    .HasForeignKey(d => d.Places)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassengerFacility_TPlaces");

                entity.HasOne(d => d.ServiceNavigation)
                    .WithMany(p => p.EpassengerFacility)
                    .HasForeignKey(d => d.Service)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassengerFacility_TService");
            });

            modelBuilder.Entity<EpassengerFacilityTt>(entity =>
            {
                entity.ToTable("EPassengerFacilityTT");

                entity.Property(e => e.EpassengerFacilityTtid)
                    .HasColumnName("EPassengerFacilityTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.PlacesNavigation)
                    .WithMany(p => p.EpassengerFacilityTt)
                    .HasForeignKey(d => d.Places)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassengerFacilityTT_TPlacesTT");

                entity.HasOne(d => d.ServiceNavigation)
                    .WithMany(p => p.EpassengerFacilityTt)
                    .HasForeignKey(d => d.Service)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPassengerFacilityTT_TService");
            });

            modelBuilder.Entity<EplatformEdges>(entity =>
            {
                entity.ToTable("EPlatformEdges");

                entity.Property(e => e.EplatformEdgesId)
                    .HasColumnName("EPlatformEdgesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PlatformEdgeNavigation)
                    .WithMany(p => p.EplatformEdges)
                    .HasForeignKey(d => d.PlatformEdge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPlatformEdges_TPlatformEdge");
            });

            modelBuilder.Entity<EpneumaticCoupler>(entity =>
            {
                entity.ToTable("EPneumaticCoupler");

                entity.Property(e => e.EpneumaticCouplerId)
                    .HasColumnName("EPneumaticCouplerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EpowerTransmissionChanges>(entity =>
            {
                entity.ToTable("EPowerTransmissionChanges");

                entity.Property(e => e.EpowerTransmissionChangesId)
                    .HasColumnName("EPowerTransmissionChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PowerTransmissionChangeNavigation)
                    .WithMany(p => p.EpowerTransmissionChanges)
                    .HasForeignKey(d => d.PowerTransmissionChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPowerTransmissionChanges_TPowerTransmissionChange");
            });

            modelBuilder.Entity<Epropulsion>(entity =>
            {
                entity.ToTable("EPropulsion");

                entity.Property(e => e.EpropulsionId)
                    .HasColumnName("EPropulsionId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AuxiliarySupplyNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.AuxiliarySupply)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_EAuxiliarySupply");

                entity.HasOne(d => d.DieselNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.Diesel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TDieselEngine");

                entity.HasOne(d => d.FourQuadrantChopperNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.FourQuadrantChopper)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_EFourQuadrantChopper");

                entity.HasOne(d => d.GearNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.Gear)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_EGear");

                entity.HasOne(d => d.LinkNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.Link)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TLink");

                entity.HasOne(d => d.RackTractionNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.RackTraction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TRackTractionType");

                entity.HasOne(d => d.TractionInverterNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractionInverter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_ETractionInverter");

                entity.HasOne(d => d.TractionMotorNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractionMotor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_ETractionMotor");

                entity.HasOne(d => d.TractiveCurrentNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractiveCurrent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TCurrentCurve");

                entity.HasOne(d => d.TractiveCurrentLimitationNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractiveCurrentLimitation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TCurrentLimitation");

                entity.HasOne(d => d.TractiveEffortNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractiveEffort)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TEffortCurve");

                entity.HasOne(d => d.TractiveVehicleEfficiencyNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.TractiveVehicleEfficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_TEfficiencyCurve");

                entity.HasOne(d => d.TransformerNavigation)
                    .WithMany(p => p.Epropulsion)
                    .HasForeignKey(d => d.Transformer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPropulsion_ETransformer");
            });

            modelBuilder.Entity<EpulsePattern>(entity =>
            {
                entity.ToTable("EPulsePattern");

                entity.Property(e => e.EpulsePatternId)
                    .HasColumnName("EPulsePatternId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ValueTableNavigation)
                    .WithMany(p => p.EpulsePattern)
                    .HasForeignKey(d => d.ValueTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EPulsePattern_EPulsePatternValueTable");
            });

            modelBuilder.Entity<EpulsePatternValueTable>(entity =>
            {
                entity.ToTable("EPulsePatternValueTable");

                entity.Property(e => e.EpulsePatternValueTableId)
                    .HasColumnName("EPulsePatternValueTableId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EradiusChanges>(entity =>
            {
                entity.ToTable("ERadiusChanges");

                entity.Property(e => e.EradiusChangesId)
                    .HasColumnName("ERadiusChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RadiusChangeNavigation)
                    .WithMany(p => p.EradiusChanges)
                    .HasForeignKey(d => d.RadiusChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERadiusChanges_TRadiusChange");
            });

            modelBuilder.Entity<EreplacedTrains>(entity =>
            {
                entity.ToTable("EReplacedTrains");

                entity.Property(e => e.EreplacedTrainsId)
                    .HasColumnName("EReplacedTrainsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ReplacementOfNavigation)
                    .WithMany(p => p.EreplacedTrains)
                    .HasForeignKey(d => d.ReplacementOf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EReplacedTrains_EReplacementOf");
            });

            modelBuilder.Entity<EreplacementOf>(entity =>
            {
                entity.ToTable("EReplacementOf");

                entity.Property(e => e.EreplacementOfId)
                    .HasColumnName("EReplacementOfId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TafTapTsiTrainId).HasColumnName("TafTapTsiTrainID");

                entity.HasOne(d => d.OperatingPeriodRefNavigation)
                    .WithMany(p => p.EreplacementOf)
                    .HasForeignKey(d => d.OperatingPeriodRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EReplacementOf_TOperatingPeriodRef");

                entity.HasOne(d => d.TafTapTsiTrain)
                    .WithMany(p => p.EreplacementOf)
                    .HasForeignKey(d => d.TafTapTsiTrainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EReplacementOf_ETapTsiTransportOperationalIdentifier");

                entity.HasOne(d => d.UniqueTrainKeyNavigation)
                    .WithMany(p => p.EreplacementOf)
                    .HasForeignKey(d => d.UniqueTrainKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EReplacementOf_TUniqueTrainKey");
            });

            modelBuilder.Entity<EreservationInfo>(entity =>
            {
                entity.ToTable("EReservationInfo");

                entity.Property(e => e.EreservationInfoId)
                    .HasColumnName("EReservationInfoId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BookingNavigation)
                    .WithMany(p => p.EreservationInfo)
                    .HasForeignKey(d => d.Booking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EReservationInfo_TBooking");
            });

            modelBuilder.Entity<Erostering>(entity =>
            {
                entity.ToTable("ERostering");

                entity.Property(e => e.ErosteringId)
                    .HasColumnName("ERosteringId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BlockPartsNavigation)
                    .WithMany(p => p.Erostering)
                    .HasForeignKey(d => d.BlockParts)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERostering_EBlockParts");

                entity.HasOne(d => d.BlocksNavigation)
                    .WithMany(p => p.Erostering)
                    .HasForeignKey(d => d.Blocks)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERostering_EBlocks");

                entity.HasOne(d => d.CirculationsNavigation)
                    .WithMany(p => p.Erostering)
                    .HasForeignKey(d => d.Circulations)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERostering_ECirculations");
            });

            modelBuilder.Entity<Erosterings>(entity =>
            {
                entity.ToTable("ERosterings");

                entity.Property(e => e.ErosteringsId)
                    .HasColumnName("ERosteringsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RosteringNavigation)
                    .WithMany(p => p.Erosterings)
                    .HasForeignKey(d => d.Rostering)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ERosterings_ERostering");
            });

            modelBuilder.Entity<EsectionTt>(entity =>
            {
                entity.ToTable("ESectionTT");

                entity.Property(e => e.EsectionTtid)
                    .HasColumnName("ESectionTTId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RunTimesNavigation)
                    .WithMany(p => p.EsectionTt)
                    .HasForeignKey(d => d.RunTimes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESectionTT_TRunTimes");

                entity.HasOne(d => d.TrackRefNavigation)
                    .WithMany(p => p.EsectionTt)
                    .HasForeignKey(d => d.TrackRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESectionTT_TTrackRef");
            });

            modelBuilder.Entity<EserviceSections>(entity =>
            {
                entity.ToTable("EServiceSections");

                entity.Property(e => e.EserviceSectionsId)
                    .HasColumnName("EServiceSectionsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ServiceSectionNavigation)
                    .WithMany(p => p.EserviceSections)
                    .HasForeignKey(d => d.ServiceSection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EServiceSections_TServiceSection");
            });

            modelBuilder.Entity<EsignalGroup>(entity =>
            {
                entity.ToTable("ESignalGroup");

                entity.Property(e => e.EsignalGroupId)
                    .HasColumnName("ESignalGroupId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SignalRefNavigation)
                    .WithMany(p => p.EsignalGroup)
                    .HasForeignKey(d => d.SignalRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESignalGroup_TSignalRefInGroup");
            });

            modelBuilder.Entity<EsignalGroups>(entity =>
            {
                entity.ToTable("ESignalGroups");

                entity.Property(e => e.EsignalGroupsId)
                    .HasColumnName("ESignalGroupsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SignalGroupNavigation)
                    .WithMany(p => p.EsignalGroups)
                    .HasForeignKey(d => d.SignalGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESignalGroups_ESignalGroup");
            });

            modelBuilder.Entity<Esignals>(entity =>
            {
                entity.ToTable("ESignals");

                entity.Property(e => e.EsignalsId)
                    .HasColumnName("ESignalsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SignalNavigation)
                    .WithMany(p => p.Esignals)
                    .HasForeignKey(d => d.Signal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESignals_TSignal");

                entity.HasOne(d => d.SignalGroupsNavigation)
                    .WithMany(p => p.Esignals)
                    .HasForeignKey(d => d.SignalGroups)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESignals_ESignalGroups");
            });

            modelBuilder.Entity<EspeedChanges>(entity =>
            {
                entity.ToTable("ESpeedChanges");

                entity.Property(e => e.EspeedChangesId)
                    .HasColumnName("ESpeedChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SpeedChangeNavigation)
                    .WithMany(p => p.EspeedChanges)
                    .HasForeignKey(d => d.SpeedChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESpeedChanges_TSpeedChange");
            });

            modelBuilder.Entity<EspeedProfiles>(entity =>
            {
                entity.ToTable("ESpeedProfiles");

                entity.Property(e => e.EspeedProfilesId)
                    .HasColumnName("ESpeedProfilesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SpeedProfileNavigation)
                    .WithMany(p => p.EspeedProfiles)
                    .HasForeignKey(d => d.SpeedProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESpeedProfiles_TSpeedProfile");
            });

            modelBuilder.Entity<Espeeds>(entity =>
            {
                entity.ToTable("ESpeeds");

                entity.Property(e => e.EspeedsId)
                    .HasColumnName("ESpeedsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SpeedNavigation)
                    .WithMany(p => p.Espeeds)
                    .HasForeignKey(d => d.Speed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESpeeds_TSpeedInfo");
            });

            modelBuilder.Entity<Estatistic>(entity =>
            {
                entity.ToTable("EStatistic");

                entity.Property(e => e.EstatisticId)
                    .HasColumnName("EStatisticId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MeanNavigation)
                    .WithMany(p => p.Estatistic)
                    .HasForeignKey(d => d.Mean)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStatistic_TStatisticTimes");

                entity.HasOne(d => d.StandardDeviationNavigation)
                    .WithMany(p => p.Estatistic)
                    .HasForeignKey(d => d.StandardDeviation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStatistic_TStandardDeviationTimes");

                entity.HasOne(d => d.StatisticAnalysesNavigation)
                    .WithMany(p => p.Estatistic)
                    .HasForeignKey(d => d.StatisticAnalyses)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStatistic_TStatisticAnalyses");
            });

            modelBuilder.Entity<Estatistics>(entity =>
            {
                entity.ToTable("EStatistics");

                entity.Property(e => e.EstatisticsId)
                    .HasColumnName("EStatisticsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StatisticNavigation)
                    .WithMany(p => p.Estatistics)
                    .HasForeignKey(d => d.Statistic)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStatistics_EStatistic");
            });

            modelBuilder.Entity<EstopActivities>(entity =>
            {
                entity.ToTable("EStopActivities");

                entity.Property(e => e.EstopActivitiesId)
                    .HasColumnName("EStopActivitiesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StopActivityNavigation)
                    .WithMany(p => p.EstopActivities)
                    .HasForeignKey(d => d.StopActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopActivities_TStopActivity");
            });

            modelBuilder.Entity<EstopDescription>(entity =>
            {
                entity.ToTable("EStopDescription");

                entity.Property(e => e.EstopDescriptionId)
                    .HasColumnName("EStopDescriptionId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AnnotationRefNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.AnnotationRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_TAnnotationRef");

                entity.HasOne(d => d.PlatformEdgeRefNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.PlatformEdgeRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_TPlatformEdgeRef");

                entity.HasOne(d => d.ServiceSectionRefNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.ServiceSectionRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_TServiceSectionRef");

                entity.HasOne(d => d.StopActivitiesNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.StopActivities)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_EStopActivities");

                entity.HasOne(d => d.StopTimesNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.StopTimes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_TStopTimes");

                entity.HasOne(d => d.TrackInfoNavigation)
                    .WithMany(p => p.EstopDescription)
                    .HasForeignKey(d => d.TrackInfo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopDescription_TStationTrackInfo");
            });

            modelBuilder.Entity<EstopPosts>(entity =>
            {
                entity.ToTable("EStopPosts");

                entity.Property(e => e.EstopPostsId)
                    .HasColumnName("EStopPostsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StopPostNavigation)
                    .WithMany(p => p.EstopPosts)
                    .HasForeignKey(d => d.StopPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStopPosts_TStopPost");
            });

            modelBuilder.Entity<Estorage>(entity =>
            {
                entity.ToTable("EStorage");

                entity.Property(e => e.EstorageId)
                    .HasColumnName("EStorageId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.Estorage)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EStorage_TEfficiencyCurve");
            });

            modelBuilder.Entity<Eswitch>(entity =>
            {
                entity.ToTable("ESwitch");

                entity.Property(e => e.EswitchId)
                    .HasColumnName("ESwitchId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ConnectionNavigation)
                    .WithMany(p => p.Eswitch)
                    .HasForeignKey(d => d.Connection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ESwitch_TSwitchConnectionData");
            });

            modelBuilder.Entity<EtapTsiTransportOperationalIdentifier>(entity =>
            {
                entity.ToTable("ETapTsiTransportOperationalIdentifier");

                entity.Property(e => e.EtapTsiTransportOperationalIdentifierId)
                    .HasColumnName("ETapTsiTransportOperationalIdentifierId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EtimetablePeriod>(entity =>
            {
                entity.ToTable("ETimetablePeriod");

                entity.Property(e => e.EtimetablePeriodId)
                    .HasColumnName("ETimetablePeriodId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.HolidaysNavigation)
                    .WithMany(p => p.EtimetablePeriod)
                    .HasForeignKey(d => d.Holidays)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETimetablePeriod_EHolidays");
            });

            modelBuilder.Entity<EtimetablePeriods>(entity =>
            {
                entity.ToTable("ETimetablePeriods");

                entity.Property(e => e.EtimetablePeriodsId)
                    .HasColumnName("ETimetablePeriodsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TimetablePeriodNavigation)
                    .WithMany(p => p.EtimetablePeriods)
                    .HasForeignKey(d => d.TimetablePeriod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETimetablePeriods_ETimetablePeriod");
            });

            modelBuilder.Entity<Etrack>(entity =>
            {
                entity.ToTable("ETrack");

                entity.Property(e => e.EtrackId)
                    .HasColumnName("ETrackId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.TrackDescr).IsRequired();

                entity.HasOne(d => d.InfraAttrGroupRefsNavigation)
                    .WithMany(p => p.Etrack)
                    .HasForeignKey(d => d.InfraAttrGroupRefs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrack_EInfraAttrGroupRefs");

                entity.HasOne(d => d.OcsElementsNavigation)
                    .WithMany(p => p.Etrack)
                    .HasForeignKey(d => d.OcsElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrack_EOcsElements");

                entity.HasOne(d => d.TrackElementsNavigation)
                    .WithMany(p => p.Etrack)
                    .HasForeignKey(d => d.TrackElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrack_ETrackElements");

                entity.HasOne(d => d.TrackTopologyNavigation)
                    .WithMany(p => p.Etrack)
                    .HasForeignKey(d => d.TrackTopology)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrack_ETrackTopology");
            });

            modelBuilder.Entity<EtrackBegin>(entity =>
            {
                entity.ToTable("ETrackBegin");

                entity.Property(e => e.EtrackBeginId)
                    .HasColumnName("ETrackBeginId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AbsDirValueNavigation)
                    .WithMany(p => p.EtrackBegin)
                    .HasForeignKey(d => d.AbsDirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackBegin_TMileageDirection");
            });

            modelBuilder.Entity<EtrackConditions>(entity =>
            {
                entity.ToTable("ETrackConditions");

                entity.Property(e => e.EtrackConditionsId)
                    .HasColumnName("ETrackConditionsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrackConditionNavigation)
                    .WithMany(p => p.EtrackConditions)
                    .HasForeignKey(d => d.TrackCondition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackConditions_TTrackCondition");
            });

            modelBuilder.Entity<EtrackElementVis>(entity =>
            {
                entity.ToTable("ETrackElementVis");

                entity.Property(e => e.EtrackElementVisId)
                    .HasColumnName("ETrackElementVisId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.EtrackElementVis)
                    .HasForeignKey(d => d.Position)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElementVis_TPoint");
            });

            modelBuilder.Entity<EtrackElements>(entity =>
            {
                entity.ToTable("ETrackElements");

                entity.Property(e => e.EtrackElementsId)
                    .HasColumnName("ETrackElementsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.AxleWeightChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.AxleWeightChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EAxleWeightChanges");

                entity.HasOne(d => d.BridgesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.Bridges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EBridges");

                entity.HasOne(d => d.ClearanceGaugeChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.ClearanceGaugeChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EClearanceGaugeChanges");

                entity.HasOne(d => d.ElectrificationChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.ElectrificationChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EElectrificationChanges");

                entity.HasOne(d => d.GaugeChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.GaugeChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EGaugeChanges");

                entity.HasOne(d => d.GeoMappingsNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.GeoMappings)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EGeoMappings");

                entity.HasOne(d => d.GradientChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.GradientChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EGradientChanges");

                entity.HasOne(d => d.LevelCrossingsNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.LevelCrossings)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ELevelCrossings");

                entity.HasOne(d => d.OperationModeChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.OperationModeChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EOperationModeChanges");

                entity.HasOne(d => d.OwnerChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.OwnerChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EOwnerChanges");

                entity.HasOne(d => d.PlatformEdgesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.PlatformEdges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EPlatformEdges");

                entity.HasOne(d => d.PowerTransmissionChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.PowerTransmissionChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EPowerTransmissionChanges");

                entity.HasOne(d => d.RadiusChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.RadiusChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ERadiusChanges");

                entity.HasOne(d => d.ServiceSectionsNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.ServiceSections)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_EServiceSections");

                entity.HasOne(d => d.SpeedChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.SpeedChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ESpeedChanges");

                entity.HasOne(d => d.TrackConditionsNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.TrackConditions)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ETrackConditions");

                entity.HasOne(d => d.TrainProtectionChangesNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.TrainProtectionChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ETrainProtectionChanges");

                entity.HasOne(d => d.TunnelsNavigation)
                    .WithMany(p => p.EtrackElements)
                    .HasForeignKey(d => d.Tunnels)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackElements_ETunnels");
            });

            modelBuilder.Entity<EtrackEnd>(entity =>
            {
                entity.ToTable("ETrackEnd");

                entity.Property(e => e.EtrackEndId)
                    .HasColumnName("ETrackEndId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsPosInValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<EtrackGroups>(entity =>
            {
                entity.ToTable("ETrackGroups");

                entity.Property(e => e.EtrackGroupsId)
                    .HasColumnName("ETrackGroupsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.LineNavigation)
                    .WithMany(p => p.EtrackGroups)
                    .HasForeignKey(d => d.Line)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackGroups_ELine");

                entity.HasOne(d => d.LocallyControlledAreaNavigation)
                    .WithMany(p => p.EtrackGroups)
                    .HasForeignKey(d => d.LocallyControlledArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackGroups_ELocallyControlledArea");
            });

            modelBuilder.Entity<EtrackNode>(entity =>
            {
                entity.ToTable("ETrackNode");

                entity.Property(e => e.EtrackNodeId)
                    .HasColumnName("ETrackNodeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Connection)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.BufferStopNavigation)
                    .WithMany(p => p.EtrackNode)
                    .HasForeignKey(d => d.BufferStop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackNode_TBufferStop");

                entity.HasOne(d => d.ConnectionNavigation)
                    .WithMany(p => p.EtrackNode)
                    .HasForeignKey(d => d.Connection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackNode_TConnectionData");

                entity.HasOne(d => d.MacroscopicNodeNavigation)
                    .WithMany(p => p.EtrackNode)
                    .HasForeignKey(d => d.MacroscopicNode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackNode_TMacroscopicNode");

                entity.HasOne(d => d.OpenEndNavigation)
                    .WithMany(p => p.EtrackNode)
                    .HasForeignKey(d => d.OpenEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackNode_TOpenEnd");
            });

            modelBuilder.Entity<EtrackTopology>(entity =>
            {
                entity.ToTable("ETrackTopology");

                entity.Property(e => e.EtrackTopologyId)
                    .HasColumnName("ETrackTopologyId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BordersNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.Borders)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_EBorder");

                entity.HasOne(d => d.ConnectionsNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.Connections)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_EConnections");

                entity.HasOne(d => d.CrossSectionsNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.CrossSections)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_ECrossSections");

                entity.HasOne(d => d.MileageChangesNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.MileageChanges)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_EMileageChanges");

                entity.HasOne(d => d.TrackBeginNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.TrackBegin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_ETrackBegin");

                entity.HasOne(d => d.TrackEndNavigation)
                    .WithMany(p => p.EtrackTopology)
                    .HasForeignKey(d => d.TrackEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackTopology_ETrackEnd");
            });

            modelBuilder.Entity<EtrackVis>(entity =>
            {
                entity.ToTable("ETrackVis");

                entity.Property(e => e.EtrackVisId)
                    .HasColumnName("ETrackVisId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrackElementVisNavigation)
                    .WithMany(p => p.EtrackVis)
                    .HasForeignKey(d => d.TrackElementVis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrackVis_ETrackElementVis");
            });

            modelBuilder.Entity<Etracks>(entity =>
            {
                entity.ToTable("ETracks");

                entity.Property(e => e.EtracksId)
                    .HasColumnName("ETracksId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrackNavigation)
                    .WithMany(p => p.Etracks)
                    .HasForeignKey(d => d.Track)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETracks_ETrack");
            });

            modelBuilder.Entity<EtractionInverter>(entity =>
            {
                entity.ToTable("ETractionInverter");

                entity.Property(e => e.EtractionInverterId)
                    .HasColumnName("ETractionInverterId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.EtractionInverter)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETractionInverter_TEfficiencyCurve");

                entity.HasOne(d => d.PulsePatternNavigation)
                    .WithMany(p => p.EtractionInverter)
                    .HasForeignKey(d => d.PulsePattern)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETractionInverter_EPulsePattern");
            });

            modelBuilder.Entity<EtractionMotor>(entity =>
            {
                entity.ToTable("ETractionMotor");

                entity.Property(e => e.EtractionMotorId)
                    .HasColumnName("ETractionMotorId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.EtractionMotor)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETractionMotor_TEfficiencyCurve");

                entity.HasOne(d => d.MechanicalLossesNavigation)
                    .WithMany(p => p.EtractionMotor)
                    .HasForeignKey(d => d.MechanicalLosses)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETractionMotor_TLosses");
            });

            modelBuilder.Entity<Etrain>(entity =>
            {
                entity.ToTable("ETrain");

                entity.Property(e => e.EtrainId)
                    .HasColumnName("ETrainId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TafTapTsiTrainId).HasColumnName("TafTapTsiTrainID");

                entity.HasOne(d => d.ReplacementsNavigation)
                    .WithMany(p => p.Etrain)
                    .HasForeignKey(d => d.Replacements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrain_EReplacedTrains");

                entity.HasOne(d => d.TafTapTsiTrain)
                    .WithMany(p => p.Etrain)
                    .HasForeignKey(d => d.TafTapTsiTrainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrain_ETapTsiTransportOperationalIdentifier");

                entity.HasOne(d => d.TrainPartSequenceNavigation)
                    .WithMany(p => p.Etrain)
                    .HasForeignKey(d => d.TrainPartSequence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrain_ETrainPartSequence");
            });

            modelBuilder.Entity<EtrainDetectionElements>(entity =>
            {
                entity.ToTable("ETrainDetectionElements");

                entity.Property(e => e.EtrainDetectionElementsId)
                    .HasColumnName("ETrainDetectionElementsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrackCircuitBorderNavigation)
                    .WithMany(p => p.EtrainDetectionElements)
                    .HasForeignKey(d => d.TrackCircuitBorder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainDetectionElements_TTrackCircuitBorder");

                entity.HasOne(d => d.TrainDetectorNavigation)
                    .WithMany(p => p.EtrainDetectionElements)
                    .HasForeignKey(d => d.TrainDetector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainDetectionElements_TTrainDetector");
            });

            modelBuilder.Entity<EtrainGroup>(entity =>
            {
                entity.ToTable("ETrainGroup");

                entity.Property(e => e.EtrainGroupId)
                    .HasColumnName("ETrainGroupId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainRefNavigation)
                    .WithMany(p => p.EtrainGroup)
                    .HasForeignKey(d => d.TrainRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainGroup_TElementRefInGroup");
            });

            modelBuilder.Entity<EtrainGroups>(entity =>
            {
                entity.ToTable("ETrainGroups");

                entity.Property(e => e.EtrainGroupsId)
                    .HasColumnName("ETrainGroupsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainGroupNavigation)
                    .WithMany(p => p.EtrainGroups)
                    .HasForeignKey(d => d.TrainGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainGroups_ETrainGroup");
            });

            modelBuilder.Entity<EtrainOrder>(entity =>
            {
                entity.ToTable("ETrainOrder");

                entity.Property(e => e.EtrainOrderId)
                    .HasColumnName("ETrainOrderId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.VehicleRefNavigation)
                    .WithMany(p => p.EtrainOrder)
                    .HasForeignKey(d => d.VehicleRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainOrder_TVehicleRef");
            });

            modelBuilder.Entity<EtrainPart>(entity =>
            {
                entity.ToTable("ETrainPart");

                entity.Property(e => e.EtrainPartId)
                    .HasColumnName("ETrainPartId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FormationTt).HasColumnName("FormationTT");

                entity.Property(e => e.OcpsTt).HasColumnName("OcpsTT");

                entity.HasOne(d => d.AnnotationRefNavigation)
                    .WithMany(p => p.EtrainPart)
                    .HasForeignKey(d => d.AnnotationRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPart_TAnnotationRef");

                entity.HasOne(d => d.FormationTtNavigation)
                    .WithMany(p => p.EtrainPart)
                    .HasForeignKey(d => d.FormationTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPart_EFormationTT");

                entity.HasOne(d => d.OcpsTtNavigation)
                    .WithMany(p => p.EtrainPart)
                    .HasForeignKey(d => d.OcpsTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPart_EOcpsTT");

                entity.HasOne(d => d.OperatingPeriodRefNavigation)
                    .WithMany(p => p.EtrainPart)
                    .HasForeignKey(d => d.OperatingPeriodRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPart_EOperatingPeriodRef");

                entity.HasOne(d => d.OrganizationalUnitBindingNavigation)
                    .WithMany(p => p.EtrainPart)
                    .HasForeignKey(d => d.OrganizationalUnitBinding)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPart_EOrganizationalUnitBinding");
            });

            modelBuilder.Entity<EtrainPartSequence>(entity =>
            {
                entity.ToTable("ETrainPartSequence");

                entity.Property(e => e.EtrainPartSequenceId)
                    .HasColumnName("ETrainPartSequenceId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.BrakeUsageNavigation)
                    .WithMany(p => p.EtrainPartSequence)
                    .HasForeignKey(d => d.BrakeUsage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPartSequence_EBrakeUsage");

                entity.HasOne(d => d.EquipmentUsageNavigation)
                    .WithMany(p => p.EtrainPartSequence)
                    .HasForeignKey(d => d.EquipmentUsage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPartSequence_EEquipmentUsage");

                entity.HasOne(d => d.SpeedProfileRefNavigation)
                    .WithMany(p => p.EtrainPartSequence)
                    .HasForeignKey(d => d.SpeedProfileRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPartSequence_TSpeedProfileRef");

                entity.HasOne(d => d.TopologyReferenceNavigation)
                    .WithMany(p => p.EtrainPartSequence)
                    .HasForeignKey(d => d.TopologyReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPartSequence_TTopologyReference");

                entity.HasOne(d => d.TrainPartRefNavigation)
                    .WithMany(p => p.EtrainPartSequence)
                    .HasForeignKey(d => d.TrainPartRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainPartSequence_TTrainPartRef");
            });

            modelBuilder.Entity<EtrainParts>(entity =>
            {
                entity.ToTable("ETrainParts");

                entity.Property(e => e.EtrainPartsId)
                    .HasColumnName("ETrainPartsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainPartNavigation)
                    .WithMany(p => p.EtrainParts)
                    .HasForeignKey(d => d.TrainPart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainParts_ETrainPart");
            });

            modelBuilder.Entity<EtrainProtectionChanges>(entity =>
            {
                entity.ToTable("ETrainProtectionChanges");

                entity.Property(e => e.EtrainProtectionChangesId)
                    .HasColumnName("ETrainProtectionChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainProtectionChangeNavigation)
                    .WithMany(p => p.EtrainProtectionChanges)
                    .HasForeignKey(d => d.TrainProtectionChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainProtectionChanges_TTrainProtectionChange");
            });

            modelBuilder.Entity<EtrainProtectionElements>(entity =>
            {
                entity.ToTable("ETrainProtectionElements");

                entity.Property(e => e.EtrainProtectionElementsId)
                    .HasColumnName("ETrainProtectionElementsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainProtectionElementNavigation)
                    .WithMany(p => p.EtrainProtectionElements)
                    .HasForeignKey(d => d.TrainProtectionElement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainProtectionElements_TTrainProtectionElement");

                entity.HasOne(d => d.TrainProtectionElementGroupNavigation)
                    .WithMany(p => p.EtrainProtectionElements)
                    .HasForeignKey(d => d.TrainProtectionElementGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainProtectionElements_TTrainProtectionElementGroup");
            });

            modelBuilder.Entity<EtrainRadio>(entity =>
            {
                entity.ToTable("ETrainRadio");

                entity.Property(e => e.EtrainRadioId)
                    .HasColumnName("ETrainRadioId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RadioSystem).IsRequired();
            });

            modelBuilder.Entity<EtrainRadioChanges>(entity =>
            {
                entity.ToTable("ETrainRadioChanges");

                entity.Property(e => e.EtrainRadioChangesId)
                    .HasColumnName("ETrainRadioChangesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainRadioChangeNavigation)
                    .WithMany(p => p.EtrainRadioChanges)
                    .HasForeignKey(d => d.TrainRadioChange)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrainRadioChanges_TTrainRadioChange");
            });

            modelBuilder.Entity<Etrains>(entity =>
            {
                entity.ToTable("ETrains");

                entity.Property(e => e.EtrainsId)
                    .HasColumnName("ETrainsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainNavigation)
                    .WithMany(p => p.Etrains)
                    .HasForeignKey(d => d.Train)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETrains_ETrain");
            });

            modelBuilder.Entity<Etransformer>(entity =>
            {
                entity.ToTable("ETransformer");

                entity.Property(e => e.EtransformerId)
                    .HasColumnName("ETransformerId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EfficiencyNavigation)
                    .WithMany(p => p.Etransformer)
                    .HasForeignKey(d => d.Efficiency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETransformer_TEfficiencyCurve");

                entity.HasOne(d => d.WindingNavigation)
                    .WithMany(p => p.Etransformer)
                    .HasForeignKey(d => d.Winding)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETransformer_TWinding");
            });

            modelBuilder.Entity<Etunnel>(entity =>
            {
                entity.ToTable("ETunnel");

                entity.Property(e => e.EtunnelId)
                    .HasColumnName("ETunnelId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CrossedElementsNavigation)
                    .WithMany(p => p.Etunnel)
                    .HasForeignKey(d => d.CrossedElements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETunnel_ECrossedElements");
            });

            modelBuilder.Entity<Etunnels>(entity =>
            {
                entity.ToTable("ETunnels");

                entity.Property(e => e.EtunnelsId)
                    .HasColumnName("ETunnelsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TunnelNavigation)
                    .WithMany(p => p.Etunnels)
                    .HasForeignKey(d => d.Tunnel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETunnels_ETunnel");
            });

            modelBuilder.Entity<Evehicle>(entity =>
            {
                entity.ToTable("EVehicle");

                entity.Property(e => e.EvehicleId)
                    .HasColumnName("EVehicleId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ClassificationNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.Classification)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_EClassification");

                entity.HasOne(d => d.CurvingLimitationNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.CurvingLimitation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_ECurvingLimitation");

                entity.HasOne(d => d.EngineNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.Engine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_EEngine");

                entity.HasOne(d => d.LoadLimitMatrixNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.LoadLimitMatrix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_ELoadLimitMatrix");

                entity.HasOne(d => d.MaintenanceIntervalsNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.MaintenanceIntervals)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_EMaintenanceIntervals");

                entity.HasOne(d => d.VehicleBrakesNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.VehicleBrakes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_EVehicleBrakes");

                entity.HasOne(d => d.WagonNavigation)
                    .WithMany(p => p.Evehicle)
                    .HasForeignKey(d => d.Wagon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicle_EWagon");
            });

            modelBuilder.Entity<EvehicleBrake>(entity =>
            {
                entity.ToTable("EVehicleBrake");

                entity.Property(e => e.EvehicleBrakeId)
                    .HasColumnName("EVehicleBrakeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoBrakePercentage).IsRequired();

                entity.Property(e => e.MaxAutoBrakeMassValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.LoadSwitchValueNavigation)
                    .WithMany(p => p.EvehicleBrake)
                    .HasForeignKey(d => d.LoadSwitchValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicleBrake_TLoadSwitch");
            });

            modelBuilder.Entity<EvehicleBrakes>(entity =>
            {
                entity.ToTable("EVehicleBrakes");

                entity.Property(e => e.EvehicleBrakesId)
                    .HasColumnName("EVehicleBrakesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EddyCurrentBrakeNavigation)
                    .WithMany(p => p.EvehicleBrakes)
                    .HasForeignKey(d => d.EddyCurrentBrake)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicleBrakes_TEddyCurrentBrake");

                entity.HasOne(d => d.MechanicalBrakeEffortNavigation)
                    .WithMany(p => p.EvehicleBrakes)
                    .HasForeignKey(d => d.MechanicalBrakeEffort)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicleBrakes_TEffortCurve");

                entity.HasOne(d => d.VehicleBrakeNavigation)
                    .WithMany(p => p.EvehicleBrakes)
                    .HasForeignKey(d => d.VehicleBrake)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicleBrakes_EVehicleBrake");

                entity.HasOne(d => d.VehicleBrakeOperationNavigation)
                    .WithMany(p => p.EvehicleBrakes)
                    .HasForeignKey(d => d.VehicleBrakeOperation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicleBrakes_TBasicBrakeOperation");
            });

            modelBuilder.Entity<Evehicles>(entity =>
            {
                entity.ToTable("EVehicles");

                entity.Property(e => e.EvehiclesId)
                    .HasColumnName("EVehiclesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.VehicleNavigation)
                    .WithMany(p => p.Evehicles)
                    .HasForeignKey(d => d.Vehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVehicles_EVehicle");
            });

            modelBuilder.Entity<Ewagon>(entity =>
            {
                entity.ToTable("EWagon");

                entity.Property(e => e.EwagonId)
                    .HasColumnName("EWagonId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.AuxiliarySupplySystemNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.AuxiliarySupplySystem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_TElectrificationSystem");

                entity.HasOne(d => d.CouplersNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.Couplers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_ECouplers");

                entity.HasOne(d => d.DriversCabNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.DriversCab)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_TDriversCabType");

                entity.HasOne(d => d.GoodsNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.Goods)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_EGoods");

                entity.HasOne(d => d.PassengerNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.Passenger)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_EPassenger");

                entity.HasOne(d => d.RackTractionNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.RackTraction)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_TRackTractionType");

                entity.HasOne(d => d.TrainClearanceGaugeNavigation)
                    .WithMany(p => p.Ewagon)
                    .HasForeignKey(d => d.TrainClearanceGauge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EWagon_TClearanceGaugeType");
            });

            modelBuilder.Entity<Format>(entity =>
            {
                entity.Property(e => e.FormatId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Identifier>(entity =>
            {
                entity.Property(e => e.IdentifierId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Infrastructure>(entity =>
            {
                entity.Property(e => e.InfrastructureId).ValueGeneratedNever();

                entity.HasOne(d => d.ControllersNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.Controllers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_EControllers");

                entity.HasOne(d => d.InfraAttrGroupsNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.InfraAttrGroups)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_EInfraAttrGroup");

                entity.HasOne(d => d.OperationControlPointsNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.OperationControlPoints)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_EOperationControlPoints");

                entity.HasOne(d => d.SpeedProfilesNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.SpeedProfiles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_ESpeedProfiles");

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_TStates");

                entity.HasOne(d => d.TrackGroupsNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.TrackGroups)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_ETrackGroups");

                entity.HasOne(d => d.TracksNavigation)
                    .WithMany(p => p.Infrastructure)
                    .HasForeignKey(d => d.Tracks)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Infrastructure_ETracks");
            });

            modelBuilder.Entity<InfrastructureVisualizations>(entity =>
            {
                entity.Property(e => e.InfrastructureVisualizationsId).ValueGeneratedNever();

                entity.Property(e => e.Base).IsRequired();

                entity.HasOne(d => d.VisualizationNavigation)
                    .WithMany(p => p.InfrastructureVisualizations)
                    .HasForeignKey(d => d.Visualization)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InfrastructureVisualizations_EInfrastructureVisualization");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Railml>(entity =>
            {
                entity.Property(e => e.RailmlId).ValueGeneratedNever();

                entity.Property(e => e.Version).IsRequired();

                entity.HasOne(d => d.InfrastructureNavigation)
                    .WithMany(p => p.Railml)
                    .HasForeignKey(d => d.Infrastructure)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Railml_Infrastructure");

                entity.HasOne(d => d.InfrastructureVisualizationsNavigation)
                    .WithMany(p => p.Railml)
                    .HasForeignKey(d => d.InfrastructureVisualizations)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Railml_InfrastructureVisualizations");

                entity.HasOne(d => d.MetadataNavigation)
                    .WithMany(p => p.Railml)
                    .HasForeignKey(d => d.Metadata)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Railml_TMetadata");

                entity.HasOne(d => d.RollingstockNavigation)
                    .WithMany(p => p.Railml)
                    .HasForeignKey(d => d.Rollingstock)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Railml_Rollingstock");

                entity.HasOne(d => d.TimetableNavigation)
                    .WithMany(p => p.Railml)
                    .HasForeignKey(d => d.Timetable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Railml_Timetable");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.Property(e => e.RelationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rights>(entity =>
            {
                entity.Property(e => e.RightsId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rollingstock>(entity =>
            {
                entity.Property(e => e.RollingstockId).ValueGeneratedNever();

                entity.HasOne(d => d.FormationsNavigation)
                    .WithMany(p => p.Rollingstock)
                    .HasForeignKey(d => d.Formations)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rollingstock_EFormations");

                entity.HasOne(d => d.VehiclesNavigation)
                    .WithMany(p => p.Rollingstock)
                    .HasForeignKey(d => d.Vehicles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rollingstock_EVehicles");
            });

            modelBuilder.Entity<SimpleLiteral>(entity =>
            {
                entity.Property(e => e.SimpleLiteralId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.Property(e => e.SourceId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TadditionalName>(entity =>
            {
                entity.ToTable("TAdditionalName");

                entity.Property(e => e.TadditionalNameId)
                    .HasColumnName("TAdditionalNameId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Lang).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TadditionalOcpName>(entity =>
            {
                entity.ToTable("TAdditionalOcpName");

                entity.Property(e => e.TadditionalOcpNameId)
                    .HasColumnName("TAdditionalOcpNameId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Lang).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TairBrakeApplicationPosition>(entity =>
            {
                entity.ToTable("TAirBrakeApplicationPosition");

                entity.Property(e => e.TairBrakeApplicationPositionId).HasColumnName("TAirBrakeApplicationPositionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<Tannotation>(entity =>
            {
                entity.ToTable("TAnnotation");

                entity.Property(e => e.TannotationId)
                    .HasColumnName("TAnnotationId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TannotationRef>(entity =>
            {
                entity.ToTable("TAnnotationRef");

                entity.Property(e => e.TannotationRefId)
                    .HasColumnName("TAnnotationRefId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OperatingPeriodRef).IsRequired();
            });

            modelBuilder.Entity<TannotationText>(entity =>
            {
                entity.ToTable("TAnnotationText");

                entity.Property(e => e.TannotationTextId)
                    .HasColumnName("TAnnotationTextId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lang).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TarrivalDepartureTimes>(entity =>
            {
                entity.ToTable("TArrivalDepartureTimes");

                entity.Property(e => e.TarrivalDepartureTimesId)
                    .HasColumnName("TArrivalDepartureTimesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivalDay).IsRequired();

                entity.Property(e => e.ArrivalValue).HasColumnType("datetime");

                entity.Property(e => e.DepartureDay).IsRequired();

                entity.Property(e => e.DepartureValue).HasColumnType("datetime");

                entity.Property(e => e.Scope).IsRequired();
            });

            modelBuilder.Entity<Tattribute>(entity =>
            {
                entity.ToTable("TAttribute");

                entity.Property(e => e.TattributeId)
                    .HasColumnName("TAttributeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TauxiliarySupply>(entity =>
            {
                entity.ToTable("TAuxiliarySupply");

                entity.Property(e => e.TauxiliarySupplyId)
                    .HasColumnName("TAuxiliarySupplyId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Power).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PowerBrakingValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PowerPhiBrakingValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PowerPhiValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ResistanceBrakingValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ResistanceValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TauxiliarySupplySystem>(entity =>
            {
                entity.ToTable("TAuxiliarySupplySystem");

                entity.Property(e => e.TauxiliarySupplySystemId)
                    .HasColumnName("TAuxiliarySupplySystemId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FrequencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxPower).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VoltageValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TaxleWeight>(entity =>
            {
                entity.ToTable("TAxleWeight");

                entity.Property(e => e.TaxleWeightId)
                    .HasColumnName("TAxleWeightId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeterloadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TaxleWeightChange>(entity =>
            {
                entity.ToTable("TAxleWeightChange");

                entity.Property(e => e.TaxleWeightChangeId)
                    .HasColumnName("TAxleWeightChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeterloadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tbalise>(entity =>
            {
                entity.ToTable("TBalise");

                entity.Property(e => e.TbaliseId)
                    .HasColumnName("TBaliseId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryId)
                    .IsRequired()
                    .HasColumnName("CountryID");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasColumnName("GroupID");

                entity.Property(e => e.LinkingAccuracy).IsRequired();

                entity.Property(e => e.Ndx).IsRequired();

                entity.Property(e => e.StaticTelegram).IsRequired();

                entity.HasOne(d => d.LinkReactionAscendingValueNavigation)
                    .WithMany(p => p.Tbalise)
                    .HasForeignKey(d => d.LinkReactionAscendingValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBalise_TBaliseLinkReaction");
            });

            modelBuilder.Entity<TbaliseGroup>(entity =>
            {
                entity.ToTable("TBaliseGroup");

                entity.Property(e => e.TbaliseGroupId)
                    .HasColumnName("TBaliseGroupId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.BaliseRefNavigation)
                    .WithMany(p => p.TbaliseGroup)
                    .HasForeignKey(d => d.BaliseRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBaliseGroup_TBaliseRefInGroup");
            });

            modelBuilder.Entity<TbaliseLinkReaction>(entity =>
            {
                entity.ToTable("TBaliseLinkReaction");

                entity.Property(e => e.TbaliseLinkReactionId).HasColumnName("TBaliseLinkReactionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(17);
            });

            modelBuilder.Entity<TbaliseRefInGroup>(entity =>
            {
                entity.ToTable("TBaliseRefInGroup");

                entity.Property(e => e.TbaliseRefInGroupId)
                    .HasColumnName("TBaliseRefInGroupId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TbasePlacedElement>(entity =>
            {
                entity.ToTable("TBasePlacedElement");

                entity.Property(e => e.TbasePlacedElementId)
                    .HasColumnName("TBasePlacedElementId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsPosOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AbsPosValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pos).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.GeoCoordNavigation)
                    .WithMany(p => p.TbasePlacedElement)
                    .HasForeignKey(d => d.GeoCoord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBasePlacedElement_TGeoCoord");
            });

            modelBuilder.Entity<TbaseServiceSection>(entity =>
            {
                entity.ToTable("TBaseServiceSection");

                entity.Property(e => e.TbaseServiceSectionId)
                    .HasColumnName("TBaseServiceSectionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.HeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OcpRef).IsRequired();

                entity.HasOne(d => d.SideValueNavigation)
                    .WithMany(p => p.TbaseServiceSection)
                    .HasForeignKey(d => d.SideValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBaseServiceSection_TSide");
            });

            modelBuilder.Entity<TbasicBrakeOperation>(entity =>
            {
                entity.ToTable("TBasicBrakeOperation");

                entity.Property(e => e.TbasicBrakeOperationId)
                    .HasColumnName("TBasicBrakeOperationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrakeSupervision).IsRequired();

                entity.Property(e => e.DecelerationDelay).IsRequired();

                entity.Property(e => e.MeanDecelerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ReleaseSpeedValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.DecelerationTableNavigation)
                    .WithMany(p => p.TbasicBrakeOperation)
                    .HasForeignKey(d => d.DecelerationTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBasicBrakeOperation_TDecelerationCurve");
            });

            modelBuilder.Entity<TbasicBrakeType>(entity =>
            {
                entity.ToTable("TBasicBrakeType");

                entity.Property(e => e.TbasicBrakeTypeId)
                    .HasColumnName("TBasicBrakeTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrakeType).IsRequired();

                entity.Property(e => e.EmergencyBrakeMassValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxDecelerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanDecelerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RegularBrakeMassValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.AirBrakeApplicationPositionValueNavigation)
                    .WithMany(p => p.TbasicBrakeType)
                    .HasForeignKey(d => d.AirBrakeApplicationPositionValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBasicBrakeType_TAirBrakeApplicationPosition");

                entity.HasOne(d => d.AuxiliaryBrakesNavigation)
                    .WithMany(p => p.TbasicBrakeType)
                    .HasForeignKey(d => d.AuxiliaryBrakes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBasicBrakeType_TBasicBrakeTypeAuxiliaryBrakes");
            });

            modelBuilder.Entity<TbasicBrakeTypeAuxiliaryBrakes>(entity =>
            {
                entity.ToTable("TBasicBrakeTypeAuxiliaryBrakes");

                entity.Property(e => e.TbasicBrakeTypeAuxiliaryBrakesId)
                    .HasColumnName("TBasicBrakeTypeAuxiliaryBrakesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Evalue).HasColumnName("EValue");

                entity.Property(e => e.EvalueSpecified).HasColumnName("EValueSpecified");

                entity.Property(e => e.Hvalue).HasColumnName("HValue");

                entity.Property(e => e.HvalueSpecified).HasColumnName("HValueSpecified");

                entity.HasOne(d => d.BrakeUseValueNavigation)
                    .WithMany(p => p.TbasicBrakeTypeAuxiliaryBrakes)
                    .HasForeignKey(d => d.BrakeUseValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBasicBrakeTypeAuxiliaryBrakes_TBrakeUse");
            });

            modelBuilder.Entity<Tblock>(entity =>
            {
                entity.ToTable("TBlock");

                entity.Property(e => e.TblockId)
                    .HasColumnName("TBlockId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlockGroupNumber).IsRequired();
            });

            modelBuilder.Entity<TblockPart>(entity =>
            {
                entity.ToTable("TBlockPart");

                entity.Property(e => e.TblockPartId)
                    .HasColumnName("TBlockPartId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginDay).IsRequired();

                entity.Property(e => e.BeginValue).HasColumnType("datetime");

                entity.Property(e => e.EndDay).IsRequired();

                entity.Property(e => e.EndOcpRef).IsRequired();

                entity.Property(e => e.EndValue).HasColumnType("datetime");

                entity.Property(e => e.FormationRef).IsRequired();

                entity.Property(e => e.Mission).IsRequired();

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.RunLengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartOcpRef).IsRequired();

                entity.Property(e => e.TrainPartRef).IsRequired();

                entity.Property(e => e.VehicleRef).IsRequired();
            });

            modelBuilder.Entity<TblockPartRef>(entity =>
            {
                entity.ToTable("TBlockPartRef");

                entity.Property(e => e.TblockPartRefId)
                    .HasColumnName("TBlockPartRefId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TblockPartSequence>(entity =>
            {
                entity.ToTable("TBlockPartSequence");

                entity.Property(e => e.TblockPartSequenceId)
                    .HasColumnName("TBlockPartSequenceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.BasicBlockRef).IsRequired();

                entity.Property(e => e.DayOffset).IsRequired();

                entity.Property(e => e.PostProcessingTime).IsRequired();

                entity.Property(e => e.PreProcessingTime).IsRequired();

                entity.Property(e => e.Sequence).IsRequired();
            });

            modelBuilder.Entity<Tbooking>(entity =>
            {
                entity.ToTable("TBooking");

                entity.Property(e => e.TbookingId)
                    .HasColumnName("TBookingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingNumber).IsRequired();

                entity.Property(e => e.PosInFormation).IsRequired();

                entity.Property(e => e.VehicleRef).IsRequired();
            });

            modelBuilder.Entity<Tborder>(entity =>
            {
                entity.ToTable("TBorder");

                entity.Property(e => e.TborderId)
                    .HasColumnName("TBorderId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TbrakeUse>(entity =>
            {
                entity.ToTable("TBrakeUse");

                entity.Property(e => e.TbrakeUseId).HasColumnName("TBrakeUseId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<Tbraking>(entity =>
            {
                entity.ToTable("TBraking");

                entity.Property(e => e.TbrakingId)
                    .HasColumnName("TBrakingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrakeType).IsRequired();

                entity.Property(e => e.MinimumBrakePercentage).IsRequired();

                entity.HasOne(d => d.AirBrakeApplicationPositionValueNavigation)
                    .WithMany(p => p.Tbraking)
                    .HasForeignKey(d => d.AirBrakeApplicationPositionValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TBraking_TAirBrakeApplicationPosition");
            });

            modelBuilder.Entity<Tbridge>(entity =>
            {
                entity.ToTable("TBridge");

                entity.Property(e => e.TbridgeId)
                    .HasColumnName("TBridgeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Kind).IsRequired();

                entity.Property(e => e.MeterloadValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TbufferStop>(entity =>
            {
                entity.ToTable("TBufferStop");

                entity.Property(e => e.TbufferStopId)
                    .HasColumnName("TBufferStopId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TcabPositionType>(entity =>
            {
                entity.ToTable("TCabPositionType");

                entity.Property(e => e.TcabPositionTypeId).HasColumnName("TCabPositionTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Tcategory>(entity =>
            {
                entity.ToTable("TCategory");

                entity.Property(e => e.TcategoryId)
                    .HasColumnName("TCategoryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryPriority).IsRequired();

                entity.HasOne(d => d.TrainUsageValueNavigation)
                    .WithMany(p => p.Tcategory)
                    .HasForeignKey(d => d.TrainUsageValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TCategory_TUsageType");
            });

            modelBuilder.Entity<Tcirculation>(entity =>
            {
                entity.ToTable("TCirculation");

                entity.Property(e => e.TcirculationId)
                    .HasColumnName("TCirculationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlockRef).IsRequired();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.NextBlockRef).IsRequired();

                entity.Property(e => e.NextOperatingPeriodRef).IsRequired();

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.RepeatCount).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.VehicleCounter).IsRequired();

                entity.Property(e => e.VehicleGroupCounter).IsRequired();
            });

            modelBuilder.Entity<TclearanceGaugeChange>(entity =>
            {
                entity.ToTable("TClearanceGaugeChange");

                entity.Property(e => e.TclearanceGaugeChangeId)
                    .HasColumnName("TClearanceGaugeChangeId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ClearanceGaugeNavigation)
                    .WithMany(p => p.TclearanceGaugeChange)
                    .HasForeignKey(d => d.ClearanceGauge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TClearanceGaugeChange_TClearanceGaugeType");
            });

            modelBuilder.Entity<TclearanceGaugeType>(entity =>
            {
                entity.ToTable("TClearanceGaugeType");

                entity.Property(e => e.TclearanceGaugeTypeId)
                    .HasColumnName("TClearanceGaugeTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).IsRequired();
            });

            modelBuilder.Entity<TcommonSwitchAndCrossingData>(entity =>
            {
                entity.ToTable("TCommonSwitchAndCrossingData");

                entity.Property(e => e.TcommonSwitchAndCrossingDataId)
                    .HasColumnName("TCommonSwitchAndCrossingDataId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.NormalPosition).IsRequired();

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.Property(e => e.TrackContinueCourse).IsRequired();

                entity.Property(e => e.TrackContinueRadiusValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tconcessionaire>(entity =>
            {
                entity.ToTable("TConcessionaire");

                entity.Property(e => e.TconcessionaireId)
                    .HasColumnName("TConcessionaireId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TconnectionData>(entity =>
            {
                entity.ToTable("TConnectionData");

                entity.Property(e => e.TconnectionDataId)
                    .HasColumnName("TConnectionDataId")
                    .HasMaxLength(255);

                entity.Property(e => e.Ref).IsRequired();
            });

            modelBuilder.Entity<TconnectionTt>(entity =>
            {
                entity.ToTable("TConnectionTT");

                entity.Property(e => e.TconnectionTtid)
                    .HasColumnName("TConnectionTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ConnOperation).IsRequired();

                entity.Property(e => e.ConnType).IsRequired();

                entity.Property(e => e.MaxConnTime).IsRequired();

                entity.Property(e => e.MinConnTime).IsRequired();

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.TrainPartRef).IsRequired();

                entity.Property(e => e.TrainRef).IsRequired();
            });

            modelBuilder.Entity<Tcontractor>(entity =>
            {
                entity.ToTable("TContractor");

                entity.Property(e => e.TcontractorId)
                    .HasColumnName("TContractorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Role).IsRequired();

                entity.Property(e => e.SubLevel).IsRequired();
            });

            modelBuilder.Entity<Tcontroller>(entity =>
            {
                entity.ToTable("TController");

                entity.Property(e => e.TcontrollerId)
                    .HasColumnName("TControllerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ParentControllerRef).IsRequired();

                entity.Property(e => e.SwVersion).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.OcpRefNavigation)
                    .WithMany(p => p.Tcontroller)
                    .HasForeignKey(d => d.OcpRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TController_TElementRefInGroup");

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.Tcontroller)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TController_TStates");

                entity.HasOne(d => d.TechnologyTypeValueNavigation)
                    .WithMany(p => p.Tcontroller)
                    .HasForeignKey(d => d.TechnologyTypeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TController_TControllerTechnologyType");
            });

            modelBuilder.Entity<TcontrollerTechnologyType>(entity =>
            {
                entity.ToTable("TControllerTechnologyType");

                entity.Property(e => e.TcontrollerTechnologyTypeId).HasColumnName("TControllerTechnologyTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<TcrossSection>(entity =>
            {
                entity.ToTable("TCrossSection");

                entity.Property(e => e.TcrossSectionId)
                    .HasColumnName("TCrossSectionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.OcpTrackIdvalue).HasColumnName("OcpTrackIDValue");

                entity.Property(e => e.OcpTrackIdvalueSpecified).HasColumnName("OcpTrackIDValueSpecified");

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TcrossSection)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TCrossSection_TLaxDirection");

                entity.HasOne(d => d.OcpCenterSideValueNavigation)
                    .WithMany(p => p.TcrossSection)
                    .HasForeignKey(d => d.OcpCenterSideValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TCrossSection_TOcpCenterSide");
            });

            modelBuilder.Entity<TcrossedElement>(entity =>
            {
                entity.ToTable("TCrossedElement");

                entity.Property(e => e.TcrossedElementId)
                    .HasColumnName("TCrossedElementId")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Tcrossing>(entity =>
            {
                entity.ToTable("TCrossing");

                entity.Property(e => e.TcrossingId)
                    .HasColumnName("TCrossingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TcurrentCurve>(entity =>
            {
                entity.ToTable("TCurrentCurve");

                entity.Property(e => e.TcurrentCurveId)
                    .HasColumnName("TCurrentCurveId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TcurrentLimitation>(entity =>
            {
                entity.ToTable("TCurrentLimitation");

                entity.Property(e => e.TcurrentLimitationId)
                    .HasColumnName("TCurrentLimitationId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Tcurve>(entity =>
            {
                entity.ToTable("TCurve");

                entity.Property(e => e.TcurveId)
                    .HasColumnName("TCurveId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.ValueTableNavigation)
                    .WithMany(p => p.Tcurve)
                    .HasForeignKey(d => d.ValueTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TCurve_TCurveValueTable");
            });

            modelBuilder.Entity<TcurveValueTable>(entity =>
            {
                entity.ToTable("TCurveValueTable");

                entity.Property(e => e.TcurveValueTableId)
                    .HasColumnName("TCurveValueTableId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TcurvingLimitationType>(entity =>
            {
                entity.ToTable("TCurvingLimitationType");

                entity.Property(e => e.TcurvingLimitationTypeId)
                    .HasColumnName("TCurvingLimitationTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.HorizontalCurveRadiusValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VerticalCrestRadiusValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VerticalSagRadiusValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tcustomer>(entity =>
            {
                entity.ToTable("TCustomer");

                entity.Property(e => e.TcustomerId)
                    .HasColumnName("TCustomerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TdecelerationCurve>(entity =>
            {
                entity.ToTable("TDecelerationCurve");

                entity.Property(e => e.TdecelerationCurveId)
                    .HasColumnName("TDecelerationCurveId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TdelimitedDirection>(entity =>
            {
                entity.ToTable("TDelimitedDirection");

                entity.Property(e => e.TdelimitedDirectionId).HasColumnName("TDelimitedDirectionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<TdelimitedOrientedElement>(entity =>
            {
                entity.ToTable("TDelimitedOrientedElement");

                entity.Property(e => e.TdelimitedOrientedElementId)
                    .HasColumnName("TDelimitedOrientedElementId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TdelimitedOrientedElement)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDelimitedOrientedElement_TDelimitedDirection");
            });

            modelBuilder.Entity<TdelimitedOrientedElementWithLength>(entity =>
            {
                entity.ToTable("TDelimitedOrientedElementWithLength");

                entity.Property(e => e.TdelimitedOrientedElementWithLengthId)
                    .HasColumnName("TDelimitedOrientedElementWithLengthId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TdelimitedOrientedElementWithLength)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDelimitedOrientedElementWithLength_TDelimitedDirection");
            });

            modelBuilder.Entity<TderailKind>(entity =>
            {
                entity.ToTable("TDerailKind");

                entity.Property(e => e.TderailKindId).HasColumnName("TDerailKindId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(17);
            });

            modelBuilder.Entity<Tderailer>(entity =>
            {
                entity.ToTable("TDerailer");

                entity.Property(e => e.TderailerId)
                    .HasColumnName("TDerailerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Model).IsRequired();

                entity.HasOne(d => d.DerailSideValueNavigation)
                    .WithMany(p => p.Tderailer)
                    .HasForeignKey(d => d.DerailSideValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDerailer_TSide");

                entity.HasOne(d => d.KindValueNavigation)
                    .WithMany(p => p.Tderailer)
                    .HasForeignKey(d => d.KindValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDerailer_TDerailKind");
            });

            modelBuilder.Entity<Tdesignator>(entity =>
            {
                entity.ToTable("TDesignator");

                entity.Property(e => e.TdesignatorId)
                    .HasColumnName("TDesignatorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.Entry).IsRequired();

                entity.Property(e => e.Register).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdieselEngine>(entity =>
            {
                entity.ToTable("TDieselEngine");

                entity.Property(e => e.TdieselEngineId)
                    .HasColumnName("TDieselEngineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.AvailableAuxiliaryPowerValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.FuelCapacityValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalPowerValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tdoors>(entity =>
            {
                entity.ToTable("TDoors");

                entity.Property(e => e.TdoorsId)
                    .HasColumnName("TDoorsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClosingTime).IsRequired();

                entity.Property(e => e.EntranceHeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EntranceLengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EntranceWidthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FootStepHeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LockingSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.OpeningTime).IsRequired();
            });

            modelBuilder.Entity<TdriversCabType>(entity =>
            {
                entity.ToTable("TDriversCabType");

                entity.Property(e => e.TdriversCabTypeId)
                    .HasColumnName("TDriversCabTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcousticSignaller).IsRequired();

                entity.Property(e => e.OrderNumber).IsRequired();

                entity.HasOne(d => d.PositionNavigation)
                    .WithMany(p => p.TdriversCabType)
                    .HasForeignKey(d => d.Position)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TDriversCabType_TCabPositionType");
            });

            modelBuilder.Entity<TeddyCurrentBrake>(entity =>
            {
                entity.ToTable("TEddyCurrentBrake");

                entity.Property(e => e.TeddyCurrentBrakeId)
                    .HasColumnName("TEddyCurrentBrakeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxEffort).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxPower).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MinSpeed).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TefficiencyCurve>(entity =>
            {
                entity.ToTable("TEfficiencyCurve");

                entity.Property(e => e.TefficiencyCurveId)
                    .HasColumnName("TEfficiencyCurveId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TeffortCurve>(entity =>
            {
                entity.ToTable("TEffortCurve");

                entity.Property(e => e.TeffortCurveId)
                    .HasColumnName("TEffortCurveId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TelectricalWagonCouplerType>(entity =>
            {
                entity.ToTable("TElectricalWagonCouplerType");

                entity.Property(e => e.TelectricalWagonCouplerTypeId)
                    .HasColumnName("TElectricalWagonCouplerTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesignType).IsRequired();

                entity.Property(e => e.NumberContacts).IsRequired();

                entity.HasOne(d => d.PositionOnCarEndNavigation)
                    .WithMany(p => p.TelectricalWagonCouplerType)
                    .HasForeignKey(d => d.PositionOnCarEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TElectricalWagonCouplerType_TEndPositionType");

                entity.HasOne(d => d.PositionOnMechanicalCouplerValueNavigation)
                    .WithMany(p => p.TelectricalWagonCouplerType)
                    .HasForeignKey(d => d.PositionOnMechanicalCouplerValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TElectricalWagonCouplerType_TRelatedPositionType");
            });

            modelBuilder.Entity<Telectrification>(entity =>
            {
                entity.ToTable("TElectrification");

                entity.Property(e => e.TelectrificationId)
                    .HasColumnName("TElectrificationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Frequency).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.Voltage).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.MaxTrainCurrentNavigation)
                    .WithMany(p => p.Telectrification)
                    .HasForeignKey(d => d.MaxTrainCurrent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TElectrification_TMaxTrainCurrent");
            });

            modelBuilder.Entity<TelectrificationChange>(entity =>
            {
                entity.ToTable("TElectrificationChange");

                entity.Property(e => e.TelectrificationChangeId)
                    .HasColumnName("TElectrificationChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Frequency).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.VmaxValue)
                    .HasColumnName("VMaxValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VmaxValueSpecified).HasColumnName("VMaxValueSpecified");

                entity.Property(e => e.Voltage).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.MaxTrainCurrentNavigation)
                    .WithMany(p => p.TelectrificationChange)
                    .HasForeignKey(d => d.MaxTrainCurrent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TElectrificationChange_TMaxTrainCurrent");
            });

            modelBuilder.Entity<TelectrificationSystem>(entity =>
            {
                entity.ToTable("TElectrificationSystem");

                entity.Property(e => e.TelectrificationSystemId)
                    .HasColumnName("TElectrificationSystemId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FrequencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VoltageValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TelementRefInGroup>(entity =>
            {
                entity.ToTable("TElementRefInGroup");

                entity.Property(e => e.TelementRefInGroupId)
                    .HasColumnName("TElementRefInGroupId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sequence).IsRequired();
            });

            modelBuilder.Entity<TelementWithIdandName>(entity =>
            {
                entity.ToTable("TElementWithIDAndName");

                entity.Property(e => e.TelementWithIdandNameId)
                    .HasColumnName("TElementWithIDAndNameId")
                    .HasMaxLength(255);

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Lang).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.AdditionalNameNavigation)
                    .WithMany(p => p.TelementWithIdandName)
                    .HasForeignKey(d => d.AdditionalName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TElementWithIDAndName_TAdditionalName");
            });

            modelBuilder.Entity<TelementWithIdandNameWithoutAny>(entity =>
            {
                entity.ToTable("TElementWithIDAndNameWithoutAny");

                entity.Property(e => e.TelementWithIdandNameWithoutAnyId)
                    .HasColumnName("TElementWithIDAndNameWithoutAnyId")
                    .HasMaxLength(255);

                entity.Property(e => e.Code).IsRequired();
            });

            modelBuilder.Entity<TelementWithReference>(entity =>
            {
                entity.ToTable("TElementWithReference");

                entity.Property(e => e.TelementWithReferenceId)
                    .HasColumnName("TElementWithReferenceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ref).IsRequired();
            });

            modelBuilder.Entity<TendPositionType>(entity =>
            {
                entity.ToTable("TEndPositionType");

                entity.Property(e => e.TendPositionTypeId).HasColumnName("TEndPositionTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Tengine>(entity =>
            {
                entity.ToTable("TEngine");

                entity.Property(e => e.TengineId)
                    .HasColumnName("TEngineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AxleDriveType).IsRequired();

                entity.Property(e => e.HaulageLoadValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TepsgCode>(entity =>
            {
                entity.ToTable("TEpsgCode");

                entity.Property(e => e.TepsgCodeId)
                    .HasColumnName("TEpsgCodeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Default).IsRequired();

                entity.Property(e => e.ExtraHeight).IsRequired();
            });

            modelBuilder.Entity<Tequipment>(entity =>
            {
                entity.ToTable("TEquipment");

                entity.Property(e => e.TequipmentId)
                    .HasColumnName("TEquipmentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Tetcs>(entity =>
            {
                entity.ToTable("TETCS");

                entity.Property(e => e.Tetcsid)
                    .HasColumnName("TETCSId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Level0value).HasColumnName("Level_0Value");

                entity.Property(e => e.Level0valueSpecified).HasColumnName("Level_0ValueSpecified");

                entity.Property(e => e.Level1value).HasColumnName("Level_1Value");

                entity.Property(e => e.Level1valueSpecified).HasColumnName("Level_1ValueSpecified");

                entity.Property(e => e.Level2value).HasColumnName("Level_2Value");

                entity.Property(e => e.Level2valueSpecified).HasColumnName("Level_2ValueSpecified");

                entity.Property(e => e.Level3value).HasColumnName("Level_3Value");

                entity.Property(e => e.Level3valueSpecified).HasColumnName("Level_3ValueSpecified");

                entity.Property(e => e.OnBoardUnitId)
                    .IsRequired()
                    .HasColumnName("OnBoardUnitID");

                entity.Property(e => e.SoftwareVersion).IsRequired();

                entity.Property(e => e.SrsVersion).IsRequired();
            });

            modelBuilder.Entity<TetcsTt>(entity =>
            {
                entity.ToTable("TEtcsTT");

                entity.Property(e => e.TetcsTtid)
                    .HasColumnName("TEtcsTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Level0value).HasColumnName("Level_0Value");

                entity.Property(e => e.Level0valueSpecified).HasColumnName("Level_0ValueSpecified");

                entity.Property(e => e.Level1value).HasColumnName("Level_1Value");

                entity.Property(e => e.Level1valueSpecified).HasColumnName("Level_1ValueSpecified");

                entity.Property(e => e.Level2value).HasColumnName("Level_2Value");

                entity.Property(e => e.Level2valueSpecified).HasColumnName("Level_2ValueSpecified");

                entity.Property(e => e.Level3value).HasColumnName("Level_3Value");

                entity.Property(e => e.Level3valueSpecified).HasColumnName("Level_3ValueSpecified");

                entity.Property(e => e.SrsVersion).IsRequired();
            });

            modelBuilder.Entity<TextendedDirection>(entity =>
            {
                entity.ToTable("TExtendedDirection");

                entity.Property(e => e.TextendedDirectionId).HasColumnName("TExtendedDirectionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<Tformation>(entity =>
            {
                entity.ToTable("TFormation");

                entity.Property(e => e.TformationId)
                    .HasColumnName("TFormationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BruttoWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EtcsTrainCategory).IsRequired();

                entity.Property(e => e.FormationCount).IsRequired();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NettoWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TareWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WeightValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TformationTt>(entity =>
            {
                entity.ToTable("TFormationTT");

                entity.Property(e => e.TformationTtid)
                    .HasColumnName("TFormationTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FormationRef).IsRequired();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TimetableLoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WeightValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TfourQuadrantChopper>(entity =>
            {
                entity.ToTable("TFourQuadrantChopper");

                entity.Property(e => e.TfourQuadrantChopperId)
                    .HasColumnName("TFourQuadrantChopperId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanPhiRegenerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanPhiValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tgangway>(entity =>
            {
                entity.ToTable("TGangway");

                entity.Property(e => e.TgangwayId)
                    .HasColumnName("TGangwayId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DesignType).IsRequired();

                entity.Property(e => e.FloorLevelValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GangwayHeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.GangwayWidthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Position).IsRequired();
            });

            modelBuilder.Entity<Tgauge>(entity =>
            {
                entity.ToTable("TGauge");

                entity.Property(e => e.TgaugeId)
                    .HasColumnName("TGaugeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TgaugeChange>(entity =>
            {
                entity.ToTable("TGaugeChange");

                entity.Property(e => e.TgaugeChangeId)
                    .HasColumnName("TGaugeChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tgear>(entity =>
            {
                entity.ToTable("TGear");

                entity.Property(e => e.TgearId)
                    .HasColumnName("TGearId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.DesignType).IsRequired();

                entity.Property(e => e.GearRatioValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ManufacturerName).IsRequired();

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalPowerValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TorqueConversion).IsRequired();
            });

            modelBuilder.Entity<TgeoCoord>(entity =>
            {
                entity.ToTable("TGeoCoord");

                entity.Property(e => e.TgeoCoordId)
                    .HasColumnName("TGeoCoordId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EpsgCode).IsRequired();

                entity.Property(e => e.HeightEpsgCode).IsRequired();
            });

            modelBuilder.Entity<TglobalElementWithMetadata>(entity =>
            {
                entity.ToTable("TGlobalElementWithMetadata");

                entity.Property(e => e.TglobalElementWithMetadataId)
                    .HasColumnName("TGlobalElementWithMetadataId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Base).IsRequired();

                entity.Property(e => e.Version).IsRequired();

                entity.HasOne(d => d.MetadataNavigation)
                    .WithMany(p => p.TglobalElementWithMetadata)
                    .HasForeignKey(d => d.Metadata)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TGlobalElementWithMetadata_ElementContainer");
            });

            modelBuilder.Entity<Tgoods>(entity =>
            {
                entity.ToTable("TGoods");

                entity.Property(e => e.TgoodsId)
                    .HasColumnName("TGoodsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FreightCarType).IsRequired();

                entity.Property(e => e.FreightCarUictype)
                    .IsRequired()
                    .HasColumnName("FreightCarUICType");

                entity.Property(e => e.LoadAreaValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VolumeValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TgradientChange>(entity =>
            {
                entity.ToTable("TGradientChange");

                entity.Property(e => e.TgradientChangeId)
                    .HasColumnName("TGradientChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Slope).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TransitionLenghtValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TransitionRadiusValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tholiday>(entity =>
            {
                entity.ToTable("THoliday");

                entity.Property(e => e.TholidayId)
                    .HasColumnName("THolidayId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.HolidayDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Timetable>(entity =>
            {
                entity.Property(e => e.TimetableId).ValueGeneratedNever();

                entity.HasOne(d => d.AnnotationsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.Annotations)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_EAnnotations");

                entity.HasOne(d => d.CategoriesNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.Categories)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ECategories");

                entity.HasOne(d => d.OperatingPeriodsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.OperatingPeriods)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_EOperatingPeriods");

                entity.HasOne(d => d.RosteringsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.Rosterings)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ERosterings");

                entity.HasOne(d => d.TimetablePeriodsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.TimetablePeriods)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ETimetablePeriods");

                entity.HasOne(d => d.TrainGroupsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.TrainGroups)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ETrainGroups");

                entity.HasOne(d => d.TrainPartsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.TrainParts)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ETrainParts");

                entity.HasOne(d => d.TrainsNavigation)
                    .WithMany(p => p.Timetable)
                    .HasForeignKey(d => d.Trains)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Timetable_ETrains");
            });

            modelBuilder.Entity<Tinfrastructure>(entity =>
            {
                entity.ToTable("TInfrastructure");

                entity.Property(e => e.TinfrastructureId)
                    .HasColumnName("TInfrastructureId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RollingstockRef).IsRequired();

                entity.Property(e => e.TimetableRef).IsRequired();
            });

            modelBuilder.Entity<TinfrastructureManager>(entity =>
            {
                entity.ToTable("TInfrastructureManager");

                entity.Property(e => e.TinfrastructureManagerId)
                    .HasColumnName("TInfrastructureManagerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TinfrastructureVisualization>(entity =>
            {
                entity.ToTable("TInfrastructureVisualization");

                entity.Property(e => e.TinfrastructureVisualizationId)
                    .HasColumnName("TInfrastructureVisualizationId")
                    .HasMaxLength(255);

                entity.Property(e => e.InfrastructureRef).IsRequired();

                entity.Property(e => e.Version).IsRequired();
            });

            modelBuilder.Entity<TinsulatedRailSide>(entity =>
            {
                entity.ToTable("TInsulatedRailSide");

                entity.Property(e => e.TinsulatedRailSideId).HasColumnName("TInsulatedRailSideId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<TinterlockingTypes>(entity =>
            {
                entity.ToTable("TInterlockingTypes");

                entity.Property(e => e.TinterlockingTypesId).HasColumnName("TInterlockingTypesId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(18);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.TitleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TlaxDirection>(entity =>
            {
                entity.ToTable("TLaxDirection");

                entity.Property(e => e.TlaxDirectionId).HasColumnName("TLaxDirectionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<TlevelCrossing>(entity =>
            {
                entity.ToTable("TLevelCrossing");

                entity.Property(e => e.TlevelCrossingId)
                    .HasColumnName("TLevelCrossingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AngleValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.Property(e => e.Protection).IsRequired();
            });

            modelBuilder.Entity<Tline>(entity =>
            {
                entity.ToTable("TLine");

                entity.Property(e => e.TlineId)
                    .HasColumnName("TLineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfrastructureManagerRef).IsRequired();

                entity.Property(e => e.LineCategory).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.Tline)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TLine_TStates");
            });

            modelBuilder.Entity<TlineClassification>(entity =>
            {
                entity.ToTable("TLineClassification");

                entity.Property(e => e.TlineClassificationId)
                    .HasColumnName("TLineClassificationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PayLoad).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tlink>(entity =>
            {
                entity.ToTable("TLink");

                entity.Property(e => e.TlinkId)
                    .HasColumnName("TLinkId")
                    .ValueGeneratedNever();

                entity.Property(e => e.NominalCurrent).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalVoltage).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TloadLimitMatrixType>(entity =>
            {
                entity.ToTable("TLoadLimitMatrixType");

                entity.Property(e => e.TloadLimitMatrixTypeId)
                    .HasColumnName("TLoadLimitMatrixTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChassisSpeedValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TloadLimitType>(entity =>
            {
                entity.ToTable("TLoadLimitType");

                entity.Property(e => e.TloadLimitTypeId)
                    .HasColumnName("TLoadLimitTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxSpeed).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TloadSwitch>(entity =>
            {
                entity.ToTable("TLoadSwitch");

                entity.Property(e => e.TloadSwitchId).HasColumnName("TLoadSwitchId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<TlocallyControlledArea>(entity =>
            {
                entity.ToTable("TLocallyControlledArea");

                entity.Property(e => e.TlocallyControlledAreaId)
                    .HasColumnName("TLocallyControlledAreaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.TlocallyControlledArea)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TLocallyControlledArea_TStates");
            });

            modelBuilder.Entity<Tlocation>(entity =>
            {
                entity.ToTable("TLocation");

                entity.Property(e => e.TlocationId)
                    .HasColumnName("TLocationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsPosOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AbsPosValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.Pos).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.GeoCoordNavigation)
                    .WithMany(p => p.Tlocation)
                    .HasForeignKey(d => d.GeoCoord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TLocation_TGeoCoord");
            });

            modelBuilder.Entity<Tlock>(entity =>
            {
                entity.ToTable("TLock");

                entity.Property(e => e.TlockId)
                    .HasColumnName("TLockId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Tlosses>(entity =>
            {
                entity.ToTable("TLosses");

                entity.Property(e => e.TlossesId)
                    .HasColumnName("TLossesId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TmacroscopicNode>(entity =>
            {
                entity.ToTable("TMacroscopicNode");

                entity.Property(e => e.TmacroscopicNodeId)
                    .HasColumnName("TMacroscopicNodeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlowDirection).IsRequired();

                entity.Property(e => e.OcpRef).IsRequired();
            });

            modelBuilder.Entity<TmaintenanceInterval>(entity =>
            {
                entity.ToTable("TMaintenanceInterval");

                entity.Property(e => e.TmaintenanceIntervalId)
                    .HasColumnName("TMaintenanceIntervalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaximumIntervalDays).IsRequired();

                entity.Property(e => e.MaximumIntervalDistanceValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tmanufacturer>(entity =>
            {
                entity.ToTable("TManufacturer");

                entity.Property(e => e.TmanufacturerId)
                    .HasColumnName("TManufacturerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ManufacturerName).IsRequired();

                entity.Property(e => e.ManufacturerType).IsRequired();

                entity.Property(e => e.SerialNumber).IsRequired();

                entity.Property(e => e.VehicleManufacturerRef).IsRequired();
            });

            modelBuilder.Entity<TmaxTrainCurrent>(entity =>
            {
                entity.ToTable("TMaxTrainCurrent");

                entity.Property(e => e.TmaxTrainCurrentId)
                    .HasColumnName("TMaxTrainCurrentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxCurrentValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.TypeValueNavigation)
                    .WithMany(p => p.TmaxTrainCurrent)
                    .HasForeignKey(d => d.TypeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMaxTrainCurrent_TMaxTrainCurrentType");

                entity.HasOne(d => d.ValidForValueNavigation)
                    .WithMany(p => p.TmaxTrainCurrent)
                    .HasForeignKey(d => d.ValidForValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMaxTrainCurrent_TMaxTrainCurrentValidFor");
            });

            modelBuilder.Entity<TmaxTrainCurrentType>(entity =>
            {
                entity.ToTable("TMaxTrainCurrentType");

                entity.Property(e => e.TmaxTrainCurrentTypeId).HasColumnName("TMaxTrainCurrentTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TmaxTrainCurrentValidFor>(entity =>
            {
                entity.ToTable("TMaxTrainCurrentValidFor");

                entity.Property(e => e.TmaxTrainCurrentValidForId).HasColumnName("TMaxTrainCurrentValidForId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TmechanicalWagonCouplerType>(entity =>
            {
                entity.ToTable("TMechanicalWagonCouplerType");

                entity.Property(e => e.TmechanicalWagonCouplerTypeId)
                    .HasColumnName("TMechanicalWagonCouplerTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CouplingHeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DesignType).IsRequired();

                entity.Property(e => e.PullingForceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PushingForceValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.PositionOnCarEndNavigation)
                    .WithMany(p => p.TmechanicalWagonCouplerType)
                    .HasForeignKey(d => d.PositionOnCarEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMechanicalWagonCouplerType_TEndPositionType");
            });

            modelBuilder.Entity<Tmetadata>(entity =>
            {
                entity.ToTable("TMetadata");

                entity.Property(e => e.TmetadataId)
                    .HasColumnName("TMetadataId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OrganizationalUnitsNavigation)
                    .WithMany(p => p.Tmetadata)
                    .HasForeignKey(d => d.OrganizationalUnits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMetadata_TOrganizationalUnits");
            });

            modelBuilder.Entity<TmileageChange>(entity =>
            {
                entity.ToTable("TMileageChange");

                entity.Property(e => e.TmileageChangeId)
                    .HasColumnName("TMileageChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsPos).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AbsPosIn).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AbsPosInOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pos).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.AbsDirValueNavigation)
                    .WithMany(p => p.TmileageChange)
                    .HasForeignKey(d => d.AbsDirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMileageChange_TMileageDirection");

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TmileageChange)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMileageChange_TStrictDirection");

                entity.HasOne(d => d.GeoCoordNavigation)
                    .WithMany(p => p.TmileageChange)
                    .HasForeignKey(d => d.GeoCoord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMileageChange_TGeoCoord");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.TmileageChange)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMileageChange_Type");
            });

            modelBuilder.Entity<TmileageChangeDescr>(entity =>
            {
                entity.ToTable("TMileageChangeDescr");

                entity.Property(e => e.TmileageChangeDescrId).HasColumnName("TMileageChangeDescrId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<TmileageDirection>(entity =>
            {
                entity.ToTable("TMileageDirection");

                entity.Property(e => e.TmileageDirectionId).HasColumnName("TMileageDirectionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<Tmonitoring>(entity =>
            {
                entity.ToTable("TMonitoring");

                entity.Property(e => e.TmonitoringId)
                    .HasColumnName("TMonitoringId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TnationalSystem>(entity =>
            {
                entity.ToTable("TNationalSystem");

                entity.Property(e => e.TnationalSystemId)
                    .HasColumnName("TNationalSystemId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OnBoardUnitId)
                    .IsRequired()
                    .HasColumnName("OnBoardUnitID");

                entity.Property(e => e.SoftwareVersion).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.TrainProtectionMediumNavigation)
                    .WithMany(p => p.TnationalSystem)
                    .HasForeignKey(d => d.TrainProtectionMedium)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TNationalSystem_TTrainProtectionMedium");

                entity.HasOne(d => d.TrainProtectionMonitoringNavigation)
                    .WithMany(p => p.TnationalSystem)
                    .HasForeignKey(d => d.TrainProtectionMonitoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TNationalSystem_TTrainProtectionMonitoring");
            });

            modelBuilder.Entity<TocpAdditionalName>(entity =>
            {
                entity.ToTable("TOcpAdditionalName");

                entity.Property(e => e.TocpAdditionalNameId)
                    .HasColumnName("TOcpAdditionalNameId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Lang).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TocpArea>(entity =>
            {
                entity.ToTable("TOcpArea");

                entity.Property(e => e.TocpAreaId)
                    .HasColumnName("TOcpAreaId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.Zip).IsRequired();
            });

            modelBuilder.Entity<TocpCenterSide>(entity =>
            {
                entity.ToTable("TOcpCenterSide");

                entity.Property(e => e.TocpCenterSideId).HasColumnName("TOcpCenterSideId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<TocpPropEquipmentSummary>(entity =>
            {
                entity.ToTable("TOcpPropEquipmentSummary");

                entity.Property(e => e.TocpPropEquipmentSummaryId)
                    .HasColumnName("TOcpPropEquipmentSummaryId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SignalBoxValueNavigation)
                    .WithMany(p => p.TocpPropEquipmentSummary)
                    .HasForeignKey(d => d.SignalBoxValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOcpPropEquipmentSummary_TInterlockingTypes");
            });

            modelBuilder.Entity<TocpPropOperational>(entity =>
            {
                entity.ToTable("TOcpPropOperational");

                entity.Property(e => e.TocpPropOperationalId)
                    .HasColumnName("TOcpPropOperationalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OperationalType).IsRequired();

                entity.Property(e => e.TrafficType).IsRequired();
            });

            modelBuilder.Entity<TocpPropOther>(entity =>
            {
                entity.ToTable("TOcpPropOther");

                entity.Property(e => e.TocpPropOtherId)
                    .HasColumnName("TOcpPropOtherId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<TocpPropService>(entity =>
            {
                entity.ToTable("TOcpPropService");

                entity.Property(e => e.TocpPropServiceId)
                    .HasColumnName("TOcpPropServiceId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TocpRefInGroup>(entity =>
            {
                entity.ToTable("TOcpRefInGroup");

                entity.Property(e => e.TocpRefInGroupId)
                    .HasColumnName("TOcpRefInGroupId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TocpTsi>(entity =>
            {
                entity.ToTable("TOcpTsi");

                entity.Property(e => e.TocpTsiId)
                    .HasColumnName("TOcpTsiId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Check).IsRequired();

                entity.Property(e => e.Country).IsRequired();

                entity.Property(e => e.Location).IsRequired();
            });

            modelBuilder.Entity<TocpTt>(entity =>
            {
                entity.ToTable("TOcpTT");

                entity.Property(e => e.TocpTtid)
                    .HasColumnName("TOcpTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.OffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.Sequence).IsRequired();

                entity.Property(e => e.ShuntingTime).IsRequired();

                entity.Property(e => e.TrackInfo).IsRequired();

                entity.Property(e => e.TrackRef).IsRequired();

                entity.HasOne(d => d.AlignmentValueNavigation)
                    .WithMany(p => p.TocpTt)
                    .HasForeignKey(d => d.AlignmentValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOcpTT_TTrainAlignment");

                entity.HasOne(d => d.OcpTypeValueNavigation)
                    .WithMany(p => p.TocpTt)
                    .HasForeignKey(d => d.OcpTypeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOcpTT_TOcpTTType");
            });

            modelBuilder.Entity<TocpTttype>(entity =>
            {
                entity.ToTable("TOcpTTType");

                entity.Property(e => e.TocpTttypeId).HasColumnName("TOcpTTTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<TocpUptime>(entity =>
            {
                entity.ToTable("TOcpUptime");

                entity.Property(e => e.TocpUptimeId)
                    .HasColumnName("TOcpUptimeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Mode).IsRequired();
            });

            modelBuilder.Entity<TocpWithIdandName>(entity =>
            {
                entity.ToTable("TOcpWithIDAndName");

                entity.Property(e => e.TocpWithIdandNameId)
                    .HasColumnName("TOcpWithIDAndNameId")
                    .HasMaxLength(255);

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.AdditionalNameNavigation)
                    .WithMany(p => p.TocpWithIdandName)
                    .HasForeignKey(d => d.AdditionalName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOcpWithIDAndName_TAdditionalOcpName");
            });

            modelBuilder.Entity<TonOff>(entity =>
            {
                entity.ToTable("TOnOff");

                entity.Property(e => e.TonOffId).HasColumnName("TOnOffId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<TopenEnd>(entity =>
            {
                entity.ToTable("TOpenEnd");

                entity.Property(e => e.TopenEndId)
                    .HasColumnName("TOpenEndId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ToperatingDay>(entity =>
            {
                entity.ToTable("TOperatingDay");

                entity.Property(e => e.ToperatingDayId)
                    .HasColumnName("TOperatingDayId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.OperatingCode).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToperatingDayDeviance>(entity =>
            {
                entity.ToTable("TOperatingDayDeviance");

                entity.Property(e => e.ToperatingDayDevianceId)
                    .HasColumnName("TOperatingDayDevianceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.HolidayOffset).IsRequired();

                entity.Property(e => e.OperatingCode).IsRequired();

                entity.Property(e => e.Ranking).IsRequired();
            });

            modelBuilder.Entity<ToperatingPeriod>(entity =>
            {
                entity.ToTable("TOperatingPeriod");

                entity.Property(e => e.ToperatingPeriodId)
                    .HasColumnName("TOperatingPeriodId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BitMask).IsRequired();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.TimetablePeriodRef).IsRequired();
            });

            modelBuilder.Entity<ToperatingPeriodRef>(entity =>
            {
                entity.ToTable("TOperatingPeriodRef");

                entity.Property(e => e.ToperatingPeriodRefId)
                    .HasColumnName("TOperatingPeriodRefId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");
            });

            modelBuilder.Entity<ToperationControlPoint>(entity =>
            {
                entity.ToTable("TOperationControlPoint");

                entity.Property(e => e.ToperationControlPointId)
                    .HasColumnName("TOperationControlPointId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abbrevation).IsRequired();

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.ParentOcpRef).IsRequired();

                entity.Property(e => e.Timezone).IsRequired();

                entity.HasOne(d => d.ControllerRefNavigation)
                    .WithMany(p => p.ToperationControlPoint)
                    .HasForeignKey(d => d.ControllerRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOperationControlPoint_TElementRefInGroup");
            });

            modelBuilder.Entity<ToperationMode>(entity =>
            {
                entity.ToTable("TOperationMode");

                entity.Property(e => e.ToperationModeId)
                    .HasColumnName("TOperationModeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClearanceManaging).IsRequired();

                entity.Property(e => e.ModeExecutive).IsRequired();

                entity.Property(e => e.ModeLegislative).IsRequired();
            });

            modelBuilder.Entity<ToperationModeChange>(entity =>
            {
                entity.ToTable("TOperationModeChange");

                entity.Property(e => e.ToperationModeChangeId)
                    .HasColumnName("TOperationModeChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClearanceManaging).IsRequired();

                entity.Property(e => e.ModeExecutive).IsRequired();

                entity.Property(e => e.ModeLegislative).IsRequired();
            });

            modelBuilder.Entity<ToperationalUndertaking>(entity =>
            {
                entity.ToTable("TOperationalUndertaking");

                entity.Property(e => e.ToperationalUndertakingId)
                    .HasColumnName("TOperationalUndertakingId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Toperator>(entity =>
            {
                entity.ToTable("TOperator");

                entity.Property(e => e.ToperatorId)
                    .HasColumnName("TOperatorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.OperatorClass).IsRequired();

                entity.Property(e => e.OperatorName).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.VehicleOperatorRef).IsRequired();
            });

            modelBuilder.Entity<TorganizationalUnits>(entity =>
            {
                entity.ToTable("TOrganizationalUnits");

                entity.Property(e => e.TorganizationalUnitsId)
                    .HasColumnName("TOrganizationalUnitsId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ConcessionaireNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.Concessionaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TConcessionaire");

                entity.HasOne(d => d.ContractorNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.Contractor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TContractor");

                entity.HasOne(d => d.CustomerNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.Customer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TCustomer");

                entity.HasOne(d => d.InfrastructureManagerNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.InfrastructureManager)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TInfrastructureManager");

                entity.HasOne(d => d.OperationalUndertakingNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.OperationalUndertaking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TOperationalUndertaking");

                entity.HasOne(d => d.RailwayUndertakingNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.RailwayUndertaking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TRailwayUndertaking");

                entity.HasOne(d => d.VehicleManufacturerNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.VehicleManufacturer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TVehicleManufacturer");

                entity.HasOne(d => d.VehicleOperatorNavigation)
                    .WithMany(p => p.TorganizationalUnits)
                    .HasForeignKey(d => d.VehicleOperator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrganizationalUnits_TVehicleOperator");
            });

            modelBuilder.Entity<TorientedElement>(entity =>
            {
                entity.ToTable("TOrientedElement");

                entity.Property(e => e.TorientedElementId)
                    .HasColumnName("TOrientedElementId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TorientedElement)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrientedElement_TLaxDirection");
            });

            modelBuilder.Entity<TorientedElementWithLength>(entity =>
            {
                entity.ToTable("TOrientedElementWithLength");

                entity.Property(e => e.TorientedElementWithLengthId)
                    .HasColumnName("TOrientedElementWithLengthId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TorientedElementWithLength)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TOrientedElementWithLength_TLaxDirection");
            });

            modelBuilder.Entity<TotherEquipment>(entity =>
            {
                entity.ToTable("TOtherEquipment");

                entity.Property(e => e.TotherEquipmentId)
                    .HasColumnName("TOtherEquipmentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OnBoardUnitId)
                    .IsRequired()
                    .HasColumnName("OnBoardUnitID");

                entity.Property(e => e.SoftwareVersion).IsRequired();
            });

            modelBuilder.Entity<Towner>(entity =>
            {
                entity.ToTable("TOwner");

                entity.Property(e => e.TownerId)
                    .HasColumnName("TOwnerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfrastructureManagerRef).IsRequired();

                entity.Property(e => e.OwnerName).IsRequired();

                entity.Property(e => e.UicNo)
                    .IsRequired()
                    .HasColumnName("Uic_No");
            });

            modelBuilder.Entity<TownerChange>(entity =>
            {
                entity.ToTable("TOwnerChange");

                entity.Property(e => e.TownerChangeId)
                    .HasColumnName("TOwnerChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfrastructureManagerRef).IsRequired();

                entity.Property(e => e.OwnerName).IsRequired();

                entity.Property(e => e.UicNo)
                    .IsRequired()
                    .HasColumnName("Uic_No");
            });

            modelBuilder.Entity<Tpantograph>(entity =>
            {
                entity.ToTable("TPantograph");

                entity.Property(e => e.TpantographId)
                    .HasColumnName("TPantographId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControlType).IsRequired();

                entity.Property(e => e.DesignType).IsRequired();

                entity.Property(e => e.FittedSection).IsRequired();

                entity.Property(e => e.HeadWidthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxCurrentDrivingValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxCurrentStandstillValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OrderNumber).IsRequired();

                entity.Property(e => e.PositionOnSection).IsRequired();
            });

            modelBuilder.Entity<Tpassenger>(entity =>
            {
                entity.ToTable("TPassenger");

                entity.Property(e => e.TpassengerId)
                    .HasColumnName("TPassengerId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DeckValueNavigation)
                    .WithMany(p => p.Tpassenger)
                    .HasForeignKey(d => d.DeckValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPassenger_TVerbalCounter");
            });

            modelBuilder.Entity<TpassengerFlowSpeed>(entity =>
            {
                entity.ToTable("TPassengerFlowSpeed");

                entity.Property(e => e.TpassengerFlowSpeedId)
                    .HasColumnName("TPassengerFlowSpeedId")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlowSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PlatformHeightValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tpath>(entity =>
            {
                entity.ToTable("TPath");

                entity.Property(e => e.TpathId)
                    .HasColumnName("TPathId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.OcpRefNavigation)
                    .WithMany(p => p.Tpath)
                    .HasForeignKey(d => d.OcpRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPath_TOcpRefInGroup");
            });

            modelBuilder.Entity<TplacedElement>(entity =>
            {
                entity.ToTable("TPlacedElement");

                entity.Property(e => e.TplacedElementId)
                    .HasColumnName("TPlacedElementId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.TplacedElement)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPlacedElement_TStates");
            });

            modelBuilder.Entity<TplacedElementWithLength>(entity =>
            {
                entity.ToTable("TPlacedElementWithLength");

                entity.Property(e => e.TplacedElementWithLengthId)
                    .HasColumnName("TPlacedElementWithLengthId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.TplacedElementWithLength)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPlacedElementWithLength_TStatesWithLength");
            });

            modelBuilder.Entity<Tplaces>(entity =>
            {
                entity.ToTable("TPlaces");

                entity.Property(e => e.TplacesId)
                    .HasColumnName("TPlacesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.TapTsiType9039Code).IsRequired();
            });

            modelBuilder.Entity<TplacesTt>(entity =>
            {
                entity.ToTable("TPlacesTT");

                entity.Property(e => e.TplacesTtid)
                    .HasColumnName("TPlacesTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Reservation).IsRequired();

                entity.Property(e => e.TapTsiType9039Code).IsRequired();
            });

            modelBuilder.Entity<TplatformEdge>(entity =>
            {
                entity.ToTable("TPlatformEdge");

                entity.Property(e => e.TplatformEdgeId)
                    .HasColumnName("TPlatformEdgeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentPlatformEdgeRef).IsRequired();
            });

            modelBuilder.Entity<TplatformEdgeRef>(entity =>
            {
                entity.ToTable("TPlatformEdgeRef");

                entity.Property(e => e.TplatformEdgeRefId)
                    .HasColumnName("TPlatformEdgeRefId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TpneumaticWagonCouplerType>(entity =>
            {
                entity.ToTable("TPneumaticWagonCouplerType");

                entity.Property(e => e.TpneumaticWagonCouplerTypeId)
                    .HasColumnName("TPneumaticWagonCouplerTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CouplerFunction).IsRequired();

                entity.HasOne(d => d.PositionOnCarEndNavigation)
                    .WithMany(p => p.TpneumaticWagonCouplerType)
                    .HasForeignKey(d => d.PositionOnCarEnd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPneumaticWagonCouplerType_TEndPositionType");
            });

            modelBuilder.Entity<Tpoint>(entity =>
            {
                entity.ToTable("TPoint");

                entity.Property(e => e.TpointId)
                    .HasColumnName("TPointId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TposInTrack>(entity =>
            {
                entity.ToTable("TPosInTrack");

                entity.Property(e => e.TposInTrackId).HasColumnName("TPosInTrackId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<TpowerTransmission>(entity =>
            {
                entity.ToTable("TPowerTransmission");

                entity.Property(e => e.TpowerTransmissionId)
                    .HasColumnName("TPowerTransmissionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Style).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TpowerTransmissionChange>(entity =>
            {
                entity.ToTable("TPowerTransmissionChange");

                entity.Property(e => e.TpowerTransmissionChangeId)
                    .HasColumnName("TPowerTransmissionChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Style).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Tpropulsion>(entity =>
            {
                entity.ToTable("TPropulsion");

                entity.Property(e => e.TpropulsionId)
                    .HasColumnName("TPropulsionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalRotationMassValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ControlType).IsRequired();

                entity.Property(e => e.ForwardSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FrequencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxBrakeEffortValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxBrakePowerValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxRegenerativeVoltageValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxTractEffortValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumberNotches).IsRequired();

                entity.Property(e => e.Power).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PowerType).IsRequired();

                entity.Property(e => e.ReverseSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RotationMassFactorValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalBrakeEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TotalTractEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TractionOffUndervoltageThresholdValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Transmission).IsRequired();

                entity.Property(e => e.VoltageValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WheelDiameterValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ZeroSpeedCurrentLimitationValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.SpeedRangeValueNavigation)
                    .WithMany(p => p.Tpropulsion)
                    .HasForeignKey(d => d.SpeedRangeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPropulsion_TSpeedRangeType");
            });

            modelBuilder.Entity<TrackTractionType>(entity =>
            {
                entity.ToTable("TRackTractionType");

                entity.Property(e => e.TrackTractionTypeId)
                    .HasColumnName("TRackTractionTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.RackSystem).IsRequired();
            });

            modelBuilder.Entity<TradiusChange>(entity =>
            {
                entity.ToTable("TRadiusChange");

                entity.Property(e => e.TradiusChangeId)
                    .HasColumnName("TRadiusChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.GeometryElementDescription).IsRequired();

                entity.Property(e => e.Radius).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SuperelevationValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TrailNetwork>(entity =>
            {
                entity.ToTable("TRailNetwork");

                entity.Property(e => e.TrailNetworkId)
                    .HasColumnName("TRailNetworkId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TrailwayUndertaking>(entity =>
            {
                entity.ToTable("TRailwayUndertaking");

                entity.Property(e => e.TrailwayUndertakingId)
                    .HasColumnName("TRailwayUndertakingId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TrelatedPositionType>(entity =>
            {
                entity.ToTable("TRelatedPositionType");

                entity.Property(e => e.TrelatedPositionTypeId).HasColumnName("TRelatedPositionTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Trollingstock>(entity =>
            {
                entity.ToTable("TRollingstock");

                entity.Property(e => e.TrollingstockId)
                    .HasColumnName("TRollingstockId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfrastructureRef).IsRequired();

                entity.Property(e => e.TimetableRef).IsRequired();
            });

            modelBuilder.Entity<Trostering>(entity =>
            {
                entity.ToTable("TRostering");

                entity.Property(e => e.TrosteringId)
                    .HasColumnName("TRosteringId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultPostProcessingTime).IsRequired();

                entity.Property(e => e.DefaultPreProcessingTime).IsRequired();

                entity.Property(e => e.Depot).IsRequired();

                entity.Property(e => e.FormationRef).IsRequired();

                entity.Property(e => e.Scope).IsRequired();

                entity.Property(e => e.VehicleRef).IsRequired();
            });

            modelBuilder.Entity<TruleCodeElement>(entity =>
            {
                entity.ToTable("TRuleCodeElement");

                entity.Property(e => e.TruleCodeElementId)
                    .HasColumnName("TRuleCodeElementId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RuleCode).IsRequired();
            });

            modelBuilder.Entity<TrunTimes>(entity =>
            {
                entity.ToTable("TRunTimes");

                entity.Property(e => e.TrunTimesId)
                    .HasColumnName("TRunTimesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalReserve).IsRequired();

                entity.Property(e => e.MinimalTime).IsRequired();

                entity.Property(e => e.OperationalReserve).IsRequired();
            });

            modelBuilder.Entity<TsectionTt>(entity =>
            {
                entity.ToTable("TSectionTT");

                entity.Property(e => e.TsectionTtid)
                    .HasColumnName("TSectionTTId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LineRef).IsRequired();

                entity.Property(e => e.PercentageSupplementValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.Section).IsRequired();

                entity.Property(e => e.TrackInfo).IsRequired();
            });

            modelBuilder.Entity<Tservice>(entity =>
            {
                entity.ToTable("TService");

                entity.Property(e => e.TserviceId)
                    .HasColumnName("TServiceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TapTsiType7161Code).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.ValueValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TserviceSection>(entity =>
            {
                entity.ToTable("TServiceSection");

                entity.Property(e => e.TserviceSectionId)
                    .HasColumnName("TServiceSectionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentServiceSectionRef).IsRequired();
            });

            modelBuilder.Entity<TserviceSectionRef>(entity =>
            {
                entity.ToTable("TServiceSectionRef");

                entity.Property(e => e.TserviceSectionRefId)
                    .HasColumnName("TServiceSectionRefId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Tside>(entity =>
            {
                entity.ToTable("TSide");

                entity.Property(e => e.TsideId).HasColumnName("TSideId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Tsignal>(entity =>
            {
                entity.ToTable("TSignal");

                entity.Property(e => e.TsignalId)
                    .HasColumnName("TSignalId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.DistNearestDangerPointValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Function).IsRequired();

                entity.Property(e => e.HeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaskableAtcvalue).HasColumnName("MaskableATCValue");

                entity.Property(e => e.MaskableAtcvalueSpecified).HasColumnName("MaskableATCValueSpecified");

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.Property(e => e.SigSystem).IsRequired();

                entity.Property(e => e.SightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SignalBoxOcpRef).IsRequired();

                entity.Property(e => e.StationOcpRef).IsRequired();

                entity.Property(e => e.TrackDistValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.BaliseGroupRefNavigation)
                    .WithMany(p => p.TsignalBaliseGroupRefNavigation)
                    .HasForeignKey(d => d.BaliseGroupRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TElementWithReference2");

                entity.HasOne(d => d.BrakingNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Braking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalBraking");

                entity.HasOne(d => d.CatenaryNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Catenary)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalCatenary");

                entity.HasOne(d => d.EtcsNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Etcs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalEtcs");

                entity.HasOne(d => d.LevelCrossingNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.LevelCrossing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalLevelCrossing");

                entity.HasOne(d => d.LineNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Line)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalLine");

                entity.HasOne(d => d.MilepostNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Milepost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalMilepost");

                entity.HasOne(d => d.SpeedNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.Speed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalSpeed");

                entity.HasOne(d => d.TrainProtectionElementGroupRefNavigation)
                    .WithMany(p => p.TsignalTrainProtectionElementGroupRefNavigation)
                    .HasForeignKey(d => d.TrainProtectionElementGroupRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TElementWithReference1");

                entity.HasOne(d => d.TrainRadioNavigation)
                    .WithMany(p => p.Tsignal)
                    .HasForeignKey(d => d.TrainRadio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignal_TSignalTrainRadio");
            });

            modelBuilder.Entity<TsignalBase>(entity =>
            {
                entity.ToTable("TSignalBase");

                entity.Property(e => e.TsignalBaseId)
                    .HasColumnName("TSignalBaseId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TsignalBraking>(entity =>
            {
                entity.ToTable("TSignalBraking");

                entity.Property(e => e.TsignalBrakingId)
                    .HasColumnName("TSignalBrakingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrackConditionRef).IsRequired();
            });

            modelBuilder.Entity<TsignalCatenary>(entity =>
            {
                entity.ToTable("TSignalCatenary");

                entity.Property(e => e.TsignalCatenaryId)
                    .HasColumnName("TSignalCatenaryId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrackConditionRef).IsRequired();
            });

            modelBuilder.Entity<TsignalEtcs>(entity =>
            {
                entity.ToTable("TSignalEtcs");

                entity.Property(e => e.TsignalEtcsId)
                    .HasColumnName("TSignalEtcsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Level0value).HasColumnName("Level_0Value");

                entity.Property(e => e.Level0valueSpecified).HasColumnName("Level_0ValueSpecified");

                entity.Property(e => e.Level1value).HasColumnName("Level_1Value");

                entity.Property(e => e.Level1valueSpecified).HasColumnName("Level_1ValueSpecified");

                entity.Property(e => e.Level2value).HasColumnName("Level_2Value");

                entity.Property(e => e.Level2valueSpecified).HasColumnName("Level_2ValueSpecified");

                entity.Property(e => e.Level3value).HasColumnName("Level_3Value");

                entity.Property(e => e.Level3valueSpecified).HasColumnName("Level_3ValueSpecified");

                entity.Property(e => e.SrsVersion).IsRequired();
            });

            modelBuilder.Entity<TsignalGroup>(entity =>
            {
                entity.ToTable("TSignalGroup");

                entity.Property(e => e.TsignalGroupId)
                    .HasColumnName("TSignalGroupId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TsignalLevelCrossing>(entity =>
            {
                entity.ToTable("TSignalLevelCrossing");

                entity.Property(e => e.TsignalLevelCrossingId)
                    .HasColumnName("TSignalLevelCrossingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ref).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TsignalLine>(entity =>
            {
                entity.ToTable("TSignalLine");

                entity.Property(e => e.TsignalLineId)
                    .HasColumnName("TSignalLineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ref).IsRequired();
            });

            modelBuilder.Entity<TsignalMilepost>(entity =>
            {
                entity.ToTable("TSignalMilepost");

                entity.Property(e => e.TsignalMilepostId)
                    .HasColumnName("TSignalMilepostId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LineRef).IsRequired();

                entity.Property(e => e.MileageChangeRef).IsRequired();

                entity.Property(e => e.ShownRemark).IsRequired();

                entity.Property(e => e.ShownValueValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TsignalRefInGroup>(entity =>
            {
                entity.ToTable("TSignalRefInGroup");

                entity.Property(e => e.TsignalRefInGroupId)
                    .HasColumnName("TSignalRefInGroupId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TsignalSpeed>(entity =>
            {
                entity.ToTable("TSignalSpeed");

                entity.Property(e => e.TsignalSpeedId)
                    .HasColumnName("TSignalSpeedId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Kind).IsRequired();

                entity.Property(e => e.TrainRelation).IsRequired();

                entity.HasOne(d => d.SpeedChangeRefNavigation)
                    .WithMany(p => p.TsignalSpeed)
                    .HasForeignKey(d => d.SpeedChangeRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSignalSpeed_TElementWithReference");
            });

            modelBuilder.Entity<TsignalTrainRadio>(entity =>
            {
                entity.ToTable("TSignalTrainRadio");

                entity.Property(e => e.TsignalTrainRadioId)
                    .HasColumnName("TSignalTrainRadioId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrackConditionRef).IsRequired();
            });

            modelBuilder.Entity<Tsize>(entity =>
            {
                entity.ToTable("TSize");

                entity.Property(e => e.TsizeId)
                    .HasColumnName("TSizeId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TspecialService>(entity =>
            {
                entity.ToTable("TSpecialService");

                entity.Property(e => e.TspecialServiceId)
                    .HasColumnName("TSpecialServiceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.EndTimeValue).HasColumnType("datetime");

                entity.Property(e => e.SingleDateValue).HasColumnType("datetime");

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.StartTimeValue).HasColumnType("datetime");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.TspecialService)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSpecialService_Type");
            });

            modelBuilder.Entity<TspecialServiceType>(entity =>
            {
                entity.ToTable("TSpecialServiceType");

                entity.Property(e => e.TspecialServiceTypeId).HasColumnName("TSpecialServiceTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<TspecificTransmissionModule>(entity =>
            {
                entity.ToTable("TSpecificTransmissionModule");

                entity.Property(e => e.TspecificTransmissionModuleId)
                    .HasColumnName("TSpecificTransmissionModuleId")
                    .ValueGeneratedNever();

                entity.Property(e => e.NationalSystemRef).IsRequired();

                entity.Property(e => e.OnBoardUnitId)
                    .IsRequired()
                    .HasColumnName("OnBoardUnitID");

                entity.Property(e => e.SoftwareVersion).IsRequired();
            });

            modelBuilder.Entity<TspeedChange>(entity =>
            {
                entity.ToTable("TSpeedChange");

                entity.Property(e => e.TspeedChangeId)
                    .HasColumnName("TSpeedChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EtcsTrainCategory).IsRequired();

                entity.Property(e => e.ProfileRef).IsRequired();

                entity.Property(e => e.Status).IsRequired();

                entity.Property(e => e.TrainCategory).IsRequired();

                entity.Property(e => e.TrainRelation).IsRequired();

                entity.Property(e => e.Vmax)
                    .IsRequired()
                    .HasColumnName("VMax");
            });

            modelBuilder.Entity<TspeedInfo>(entity =>
            {
                entity.ToTable("TSpeedInfo");

                entity.Property(e => e.TspeedInfoId)
                    .HasColumnName("TSpeedInfoId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EtcsTrainCategory).IsRequired();

                entity.Property(e => e.ProfileRef).IsRequired();

                entity.Property(e => e.Status).IsRequired();

                entity.Property(e => e.TrainCategory).IsRequired();

                entity.Property(e => e.Vmax)
                    .IsRequired()
                    .HasColumnName("VMax");
            });

            modelBuilder.Entity<TspeedProfile>(entity =>
            {
                entity.ToTable("TSpeedProfile");

                entity.Property(e => e.TspeedProfileId)
                    .HasColumnName("TSpeedProfileId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDayOffset).IsRequired();

                entity.Property(e => e.EndTimeValue).HasColumnType("datetime");

                entity.Property(e => e.Influence).IsRequired();

                entity.Property(e => e.MaxAxleLoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaxMeterLoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.StartTimeValue).HasColumnType("datetime");

                entity.Property(e => e.TrainProtectionSystem).IsRequired();

                entity.Property(e => e.VerbalConstraint).IsRequired();

                entity.HasOne(d => d.BrakingNavigation)
                    .WithMany(p => p.TspeedProfile)
                    .HasForeignKey(d => d.Braking)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSpeedProfile_TBraking");

                entity.HasOne(d => d.PathNavigation)
                    .WithMany(p => p.TspeedProfile)
                    .HasForeignKey(d => d.Path)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSpeedProfile_TPath");

                entity.HasOne(d => d.TiltingNavigation)
                    .WithMany(p => p.TspeedProfile)
                    .HasForeignKey(d => d.Tilting)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TSpeedProfile_TTilting");
            });

            modelBuilder.Entity<TspeedProfileRef>(entity =>
            {
                entity.ToTable("TSpeedProfileRef");

                entity.Property(e => e.TspeedProfileRefId)
                    .HasColumnName("TSpeedProfileRefId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TspeedProfileRefRs>(entity =>
            {
                entity.ToTable("TSpeedProfileRefRS");

                entity.Property(e => e.TspeedProfileRefRsid)
                    .HasColumnName("TSpeedProfileRefRSId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Ref).IsRequired();
            });

            modelBuilder.Entity<TspeedRangeType>(entity =>
            {
                entity.ToTable("TSpeedRangeType");

                entity.Property(e => e.TspeedRangeTypeId).HasColumnName("TSpeedRangeTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<TstandardDeviationTimes>(entity =>
            {
                entity.ToTable("TStandardDeviationTimes");

                entity.Property(e => e.TstandardDeviationTimesId)
                    .HasColumnName("TStandardDeviationTimesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivalDelay).IsRequired();

                entity.Property(e => e.DepartureDelay).IsRequired();
            });

            modelBuilder.Entity<Tstate>(entity =>
            {
                entity.ToTable("TState");

                entity.Property(e => e.TstateId)
                    .HasColumnName("TStateId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EndDayOffset).IsRequired();

                entity.Property(e => e.EndTimeValue).HasColumnType("datetime");

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.StartTimeValue).HasColumnType("datetime");

                entity.Property(e => e.Status).IsRequired();
            });

            modelBuilder.Entity<TstateWithLength>(entity =>
            {
                entity.ToTable("TStateWithLength");

                entity.Property(e => e.TstateWithLengthId)
                    .HasColumnName("TStateWithLengthId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.FromNavigation)
                    .WithMany(p => p.TstateWithLength)
                    .HasForeignKey(d => d.From)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStateWithLength_TLocation");
            });

            modelBuilder.Entity<Tstates>(entity =>
            {
                entity.ToTable("TStates");

                entity.Property(e => e.TstatesId)
                    .HasColumnName("TStatesId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Tstates)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStates_TState");
            });

            modelBuilder.Entity<TstatesWithLength>(entity =>
            {
                entity.ToTable("TStatesWithLength");

                entity.Property(e => e.TstatesWithLengthId)
                    .HasColumnName("TStatesWithLengthId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.TstatesWithLength)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStatesWithLength_TStateWithLength");
            });

            modelBuilder.Entity<TstationTrackInfo>(entity =>
            {
                entity.ToTable("TStationTrackInfo");

                entity.Property(e => e.TstationTrackInfoId)
                    .HasColumnName("TStationTrackInfoId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.Platform).IsRequired();

                entity.Property(e => e.Track).IsRequired();
            });

            modelBuilder.Entity<Tstatistic>(entity =>
            {
                entity.ToTable("TStatistic");

                entity.Property(e => e.TstatisticId)
                    .HasColumnName("TStatisticId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TstatisticAnalyses>(entity =>
            {
                entity.ToTable("TStatisticAnalyses");

                entity.Property(e => e.TstatisticAnalysesId)
                    .HasColumnName("TStatisticAnalysesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Figure).IsRequired();

                entity.Property(e => e.PercentageValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<TstatisticTimes>(entity =>
            {
                entity.ToTable("TStatisticTimes");

                entity.Property(e => e.TstatisticTimesId)
                    .HasColumnName("TStatisticTimesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivalDay).IsRequired();

                entity.Property(e => e.ArrivalDelay).IsRequired();

                entity.Property(e => e.ArrivalValue).HasColumnType("datetime");

                entity.Property(e => e.DepartureDay).IsRequired();

                entity.Property(e => e.DepartureDelay).IsRequired();

                entity.Property(e => e.DepartureValue).HasColumnType("datetime");

                entity.Property(e => e.StopTime).IsRequired();
            });

            modelBuilder.Entity<TstopActivity>(entity =>
            {
                entity.ToTable("TStopActivity");

                entity.Property(e => e.TstopActivityId)
                    .HasColumnName("TStopActivityId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TstopDescription>(entity =>
            {
                entity.ToTable("TStopDescription");

                entity.Property(e => e.TstopDescriptionId)
                    .HasColumnName("TStopDescriptionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OperatingPeriodRef).IsRequired();

                entity.Property(e => e.Purpose).IsRequired();

                entity.Property(e => e.StopPostRef).IsRequired();

                entity.HasOne(d => d.OnOffValueNavigation)
                    .WithMany(p => p.TstopDescription)
                    .HasForeignKey(d => d.OnOffValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStopDescription_TOnOff");
            });

            modelBuilder.Entity<TstopPost>(entity =>
            {
                entity.ToTable("TStopPost");

                entity.Property(e => e.TstopPostId)
                    .HasColumnName("TStopPostId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AxleCount).IsRequired();

                entity.Property(e => e.OcpRef).IsRequired();

                entity.Property(e => e.PlatformEdgeRef).IsRequired();

                entity.Property(e => e.TrainLengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TrainRelation).IsRequired();

                entity.Property(e => e.VerbalConstraints).IsRequired();

                entity.Property(e => e.WagonCount).IsRequired();

                entity.HasOne(d => d.SignalRefNavigation)
                    .WithMany(p => p.TstopPost)
                    .HasForeignKey(d => d.SignalRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStopPost_TElementWithReference");

                entity.HasOne(d => d.ValidForMovementsNavigation)
                    .WithMany(p => p.TstopPost)
                    .HasForeignKey(d => d.ValidForMovements)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStopPost_TValidForMovements");
            });

            modelBuilder.Entity<TstopTimes>(entity =>
            {
                entity.ToTable("TStopTimes");

                entity.Property(e => e.TstopTimesId)
                    .HasColumnName("TStopTimesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalReserve).IsRequired();

                entity.Property(e => e.ClearanceTime).IsRequired();

                entity.Property(e => e.MinimalTime).IsRequired();

                entity.Property(e => e.OperationalReserve).IsRequired();

                entity.Property(e => e.ShuntingTime).IsRequired();
            });

            modelBuilder.Entity<Tstorage>(entity =>
            {
                entity.ToTable("TStorage");

                entity.Property(e => e.TstorageId)
                    .HasColumnName("TStorageId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChargingEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DischargingEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaximumChargingEnergy).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaximumCurrentCharging).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaximumCurrentDischarging).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaximumPowerCharging).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MaximumPowerDischarging).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanStorageEfficiencyValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TstrictDirection>(entity =>
            {
                entity.ToTable("TStrictDirection");

                entity.Property(e => e.TstrictDirectionId).HasColumnName("TStrictDirectionId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<TstrictOrientedElement>(entity =>
            {
                entity.ToTable("TStrictOrientedElement");

                entity.Property(e => e.TstrictOrientedElementId)
                    .HasColumnName("TStrictOrientedElementId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TstrictOrientedElement)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStrictOrientedElement_TStrictDirection");
            });

            modelBuilder.Entity<TstrictOrientedElementWithLength>(entity =>
            {
                entity.ToTable("TStrictOrientedElementWithLength");

                entity.Property(e => e.TstrictOrientedElementWithLengthId)
                    .HasColumnName("TStrictOrientedElementWithLengthId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TstrictOrientedElementWithLength)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TStrictOrientedElementWithLength_TStrictDirection");
            });

            modelBuilder.Entity<Tswitch>(entity =>
            {
                entity.ToTable("TSwitch");

                entity.Property(e => e.TswitchId)
                    .HasColumnName("TSwitchId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TswitchConnectionData>(entity =>
            {
                entity.ToTable("TSwitchConnectionData");

                entity.Property(e => e.TswitchConnectionDataId)
                    .HasColumnName("TSwitchConnectionDataId")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchDistValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Course).IsRequired();

                entity.Property(e => e.MaxSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Orientation).IsRequired();

                entity.Property(e => e.RadiusValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TtapTsiCompositIdentifierOperationalType>(entity =>
            {
                entity.ToTable("TTapTsiCompositIdentifierOperationalType");

                entity.Property(e => e.TtapTsiCompositIdentifierOperationalTypeId)
                    .HasColumnName("TTapTsiCompositIdentifierOperationalTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyCode).IsRequired();

                entity.Property(e => e.Core).IsRequired();

                entity.Property(e => e.ObjectType).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.TimetableYear).IsRequired();

                entity.Property(e => e.Variant).IsRequired();
            });

            modelBuilder.Entity<TtechnicalStopActivity>(entity =>
            {
                entity.ToTable("TTechnicalStopActivity");

                entity.Property(e => e.TtechnicalStopActivityId)
                    .HasColumnName("TTechnicalStopActivityId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MinimumTime).IsRequired();

                entity.Property(e => e.Purpose).IsRequired();
            });

            modelBuilder.Entity<Ttilting>(entity =>
            {
                entity.ToTable("TTilting");

                entity.Property(e => e.TtiltingId)
                    .HasColumnName("TTiltingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxTiltingAngleValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TiltingSpeedValue).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.ActuationValueNavigation)
                    .WithMany(p => p.Ttilting)
                    .HasForeignKey(d => d.ActuationValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTilting_TTiltingActuationType");
            });

            modelBuilder.Entity<TtiltingActuationType>(entity =>
            {
                entity.ToTable("TTiltingActuationType");

                entity.Property(e => e.TtiltingActuationTypeId).HasColumnName("TTiltingActuationTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<TtimeSpan>(entity =>
            {
                entity.ToTable("TTimeSpan");

                entity.Property(e => e.TtimeSpanId)
                    .HasColumnName("TTimeSpanId")
                    .ValueGeneratedNever();

                entity.Property(e => e.From).HasColumnType("datetime");

                entity.Property(e => e.Until).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ttimetable>(entity =>
            {
                entity.ToTable("TTimetable");

                entity.Property(e => e.TtimetableId)
                    .HasColumnName("TTimetableId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfrastructureRef).IsRequired();

                entity.Property(e => e.RollingstockRef).IsRequired();
            });

            modelBuilder.Entity<TtimetablePeriod>(entity =>
            {
                entity.ToTable("TTimetablePeriod");

                entity.Property(e => e.TtimetablePeriodId)
                    .HasColumnName("TTimetablePeriodId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.EndTimeValue).HasColumnType("datetime");

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");

                entity.Property(e => e.StartTimeValue).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtopologyReference>(entity =>
            {
                entity.ToTable("TTopologyReference");

                entity.Property(e => e.TtopologyReferenceId)
                    .HasColumnName("TTopologyReferenceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDateValue).HasColumnType("datetime");

                entity.Property(e => e.Entry).IsRequired();

                entity.Property(e => e.Register).IsRequired();

                entity.Property(e => e.StartDateValue).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ttrack>(entity =>
            {
                entity.ToTable("TTrack");

                entity.Property(e => e.TtrackId)
                    .HasColumnName("TTrackId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InfraAttrGroupRef).IsRequired();

                entity.Property(e => e.Type).IsRequired();

                entity.HasOne(d => d.MainDirValueNavigation)
                    .WithMany(p => p.Ttrack)
                    .HasForeignKey(d => d.MainDirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrack_TExtendedDirection");

                entity.HasOne(d => d.StatesNavigation)
                    .WithMany(p => p.Ttrack)
                    .HasForeignKey(d => d.States)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrack_TStatesWithLength");
            });

            modelBuilder.Entity<TtrackCircuitBorder>(entity =>
            {
                entity.ToTable("TTrackCircuitBorder");

                entity.Property(e => e.TtrackCircuitBorderId)
                    .HasColumnName("TTrackCircuitBorderId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.HasOne(d => d.InsulatedRailValueNavigation)
                    .WithMany(p => p.TtrackCircuitBorder)
                    .HasForeignKey(d => d.InsulatedRailValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrackCircuitBorder_TInsulatedRailSide");
            });

            modelBuilder.Entity<TtrackCondition>(entity =>
            {
                entity.ToTable("TTrackCondition");

                entity.Property(e => e.TtrackConditionId)
                    .HasColumnName("TTrackConditionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TtrackNode>(entity =>
            {
                entity.ToTable("TTrackNode");

                entity.Property(e => e.TtrackNodeId)
                    .HasColumnName("TTrackNodeId")
                    .HasMaxLength(255);

                entity.Property(e => e.AbsPosOffsetValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AbsPosValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pos).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.GeoCoordNavigation)
                    .WithMany(p => p.TtrackNode)
                    .HasForeignKey(d => d.GeoCoord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrackNode_TGeoCoord");
            });

            modelBuilder.Entity<TtrackRef>(entity =>
            {
                entity.ToTable("TTrackRef");

                entity.Property(e => e.TtrackRefId)
                    .HasColumnName("TTrackRefId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DirValueNavigation)
                    .WithMany(p => p.TtrackRef)
                    .HasForeignKey(d => d.DirValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrackRef_TStrictDirection");
            });

            modelBuilder.Entity<TtrackRefInGroup>(entity =>
            {
                entity.ToTable("TTrackRefInGroup");

                entity.Property(e => e.TtrackRefInGroupId)
                    .HasColumnName("TTrackRefInGroupId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TtractionInverter>(entity =>
            {
                entity.ToTable("TTractionInverter");

                entity.Property(e => e.TtractionInverterId)
                    .HasColumnName("TTractionInverterId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TtractionMotor>(entity =>
            {
                entity.ToTable("TTractionMotor");

                entity.Property(e => e.TtractionMotorId)
                    .HasColumnName("TTractionMotorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.FerrumResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MainInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalCurrentValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalFluxValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalFrequencyValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalPhiValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalPowerValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalRevolutions).IsRequired();

                entity.Property(e => e.NominalVoltageValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumberPolePairs).IsRequired();

                entity.Property(e => e.RotorLeakageInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.RotorResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StatorLeakageInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StatorResistanceValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Ttrain>(entity =>
            {
                entity.ToTable("TTrain");

                entity.Property(e => e.TtrainId)
                    .HasColumnName("TTrainId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalTrainNumber).IsRequired();

                entity.Property(e => e.ProcessStatus).IsRequired();

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.TrainNumber).IsRequired();

                entity.HasOne(d => d.ScopeValueNavigation)
                    .WithMany(p => p.Ttrain)
                    .HasForeignKey(d => d.ScopeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrain_TTrainScope");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Ttrain)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrain_Type");
            });

            modelBuilder.Entity<TtrainAlignment>(entity =>
            {
                entity.ToTable("TTrainAlignment");

                entity.Property(e => e.TtrainAlignmentId).HasColumnName("TTrainAlignmentId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<TtrainDetector>(entity =>
            {
                entity.ToTable("TTrainDetector");

                entity.Property(e => e.TtrainDetectorId)
                    .HasColumnName("TTrainDetectorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerRef).IsRequired();

                entity.Property(e => e.DetectionObject).IsRequired();

                entity.Property(e => e.Medium).IsRequired();

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.OcpStationRef).IsRequired();

                entity.HasOne(d => d.PosInTrackValueNavigation)
                    .WithMany(p => p.TtrainDetector)
                    .HasForeignKey(d => d.PosInTrackValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainDetector_TPosInTrack");
            });

            modelBuilder.Entity<TtrainEngine>(entity =>
            {
                entity.ToTable("TTrainEngine");

                entity.Property(e => e.TtrainEngineId)
                    .HasColumnName("TTrainEngineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrainMaxAccelerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TrainMeanAccelerationValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TrainMinTimeHoldSpeed).IsRequired();
            });

            modelBuilder.Entity<TtrainGroup>(entity =>
            {
                entity.ToTable("TTrainGroup");

                entity.Property(e => e.TtrainGroupId)
                    .HasColumnName("TTrainGroupId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProcessStatus).IsRequired();

                entity.Property(e => e.TrainNumber).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<TtrainPart>(entity =>
            {
                entity.ToTable("TTrainPart");

                entity.Property(e => e.TtrainPartId)
                    .HasColumnName("TTrainPartId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalTrainNumber).IsRequired();

                entity.Property(e => e.CategoryRef).IsRequired();

                entity.Property(e => e.Debitcode).IsRequired();

                entity.Property(e => e.Line).IsRequired();

                entity.Property(e => e.Operator).IsRequired();

                entity.Property(e => e.ProcessStatus).IsRequired();

                entity.Property(e => e.Remarks).IsRequired();

                entity.Property(e => e.TimetablePeriodRef).IsRequired();

                entity.Property(e => e.TrainLine).IsRequired();

                entity.Property(e => e.TrainNumber).IsRequired();
            });

            modelBuilder.Entity<TtrainPartRef>(entity =>
            {
                entity.ToTable("TTrainPartRef");

                entity.Property(e => e.TtrainPartRefId)
                    .HasColumnName("TTrainPartRefId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Position).IsRequired();
            });

            modelBuilder.Entity<TtrainPartSequence>(entity =>
            {
                entity.ToTable("TTrainPartSequence");

                entity.Property(e => e.TtrainPartSequenceId)
                    .HasColumnName("TTrainPartSequenceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Any)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.CategoryRef).IsRequired();

                entity.Property(e => e.PathStatus).IsRequired();

                entity.Property(e => e.Sequence).IsRequired();
            });

            modelBuilder.Entity<TtrainProtection>(entity =>
            {
                entity.ToTable("TTrainProtection");

                entity.Property(e => e.TtrainProtectionId)
                    .HasColumnName("TTrainProtectionId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MediumValueNavigation)
                    .WithMany(p => p.TtrainProtection)
                    .HasForeignKey(d => d.MediumValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtection_TTrainProtectionMedium");

                entity.HasOne(d => d.MonitoringNavigation)
                    .WithMany(p => p.TtrainProtection)
                    .HasForeignKey(d => d.Monitoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtection_TTrainProtectionMonitoring");
            });

            modelBuilder.Entity<TtrainProtectionChange>(entity =>
            {
                entity.ToTable("TTrainProtectionChange");

                entity.Property(e => e.TtrainProtectionChangeId)
                    .HasColumnName("TTrainProtectionChangeId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.MediumValueNavigation)
                    .WithMany(p => p.TtrainProtectionChange)
                    .HasForeignKey(d => d.MediumValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtectionChange_TTrainProtectionMedium");

                entity.HasOne(d => d.MonitoringNavigation)
                    .WithMany(p => p.TtrainProtectionChange)
                    .HasForeignKey(d => d.Monitoring)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtectionChange_TTrainProtectionMonitoring");
            });

            modelBuilder.Entity<TtrainProtectionElement>(entity =>
            {
                entity.ToTable("TTrainProtectionElement");

                entity.Property(e => e.TtrainProtectionElementId)
                    .HasColumnName("TTrainProtectionElementId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.System).IsRequired();

                entity.Property(e => e.TrainProtectionSystem).IsRequired();

                entity.HasOne(d => d.MediumValueNavigation)
                    .WithMany(p => p.TtrainProtectionElement)
                    .HasForeignKey(d => d.MediumValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtectionElement_TTrainProtectionMedium");
            });

            modelBuilder.Entity<TtrainProtectionElementGroup>(entity =>
            {
                entity.ToTable("TTrainProtectionElementGroup");

                entity.Property(e => e.TtrainProtectionElementGroupId)
                    .HasColumnName("TTrainProtectionElementGroupId")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.TrainProtectionElementRefNavigation)
                    .WithMany(p => p.TtrainProtectionElementGroup)
                    .HasForeignKey(d => d.TrainProtectionElementRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TTrainProtectionElementGroup_TElementWithReference");
            });

            modelBuilder.Entity<TtrainProtectionMedium>(entity =>
            {
                entity.ToTable("TTrainProtectionMedium");

                entity.Property(e => e.TtrainProtectionMediumId).HasColumnName("TTrainProtectionMediumId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TtrainProtectionMonitoring>(entity =>
            {
                entity.ToTable("TTrainProtectionMonitoring");

                entity.Property(e => e.TtrainProtectionMonitoringId).HasColumnName("TTrainProtectionMonitoringId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<TtrainRadio>(entity =>
            {
                entity.ToTable("TTrainRadio");

                entity.Property(e => e.TtrainRadioId)
                    .HasColumnName("TTrainRadioId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Modulation).IsRequired();

                entity.Property(e => e.OnBoardUnitId)
                    .IsRequired()
                    .HasColumnName("OnBoardUnitID");

                entity.Property(e => e.SoftwareVersion).IsRequired();
            });

            modelBuilder.Entity<TtrainRadioAttributes>(entity =>
            {
                entity.ToTable("TTrainRadioAttributes");

                entity.Property(e => e.TtrainRadioAttributesId)
                    .HasColumnName("TTrainRadioAttributesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.NetworkSelection).IsRequired();

                entity.Property(e => e.RadioSystem).IsRequired();
            });

            modelBuilder.Entity<TtrainRadioChange>(entity =>
            {
                entity.ToTable("TTrainRadioChange");

                entity.Property(e => e.TtrainRadioChangeId)
                    .HasColumnName("TTrainRadioChangeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.NetworkSelection).IsRequired();

                entity.Property(e => e.RadioSystem).IsRequired();
            });

            modelBuilder.Entity<TtrainResistance>(entity =>
            {
                entity.ToTable("TTrainResistance");

                entity.Property(e => e.TtrainResistanceId)
                    .HasColumnName("TTrainResistanceId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DaviesFactorAvalue)
                    .HasColumnName("DaviesFactorAValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DaviesFactorAvalueSpecified).HasColumnName("DaviesFactorAValueSpecified");

                entity.Property(e => e.DaviesFactorBvalue)
                    .HasColumnName("DaviesFactorBValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DaviesFactorBvalueSpecified).HasColumnName("DaviesFactorBValueSpecified");

                entity.Property(e => e.DaviesFactorCvalue)
                    .HasColumnName("DaviesFactorCValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DaviesFactorCvalueSpecified).HasColumnName("DaviesFactorCValueSpecified");

                entity.Property(e => e.StrahlFactorValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TunnelFactorValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TtrainScope>(entity =>
            {
                entity.ToTable("TTrainScope");

                entity.Property(e => e.TtrainScopeId).HasColumnName("TTrainScopeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(14);
            });

            modelBuilder.Entity<TtrainType>(entity =>
            {
                entity.ToTable("TTrainType");

                entity.Property(e => e.TtrainTypeId).HasColumnName("TTrainTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<Ttransformer>(entity =>
            {
                entity.ToTable("TTransformer");

                entity.Property(e => e.TtransformerId)
                    .HasColumnName("TTransformerId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.Count).IsRequired();

                entity.Property(e => e.FerrumResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MainInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MeanEfficiencyValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Ttunnel>(entity =>
            {
                entity.ToTable("TTunnel");

                entity.Property(e => e.TtunnelId)
                    .HasColumnName("TTunnelId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrossSectionValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Kind).IsRequired();
            });

            modelBuilder.Entity<TuniqueTrainKey>(entity =>
            {
                entity.ToTable("TUniqueTrainKey");

                entity.Property(e => e.TuniqueTrainKeyId)
                    .HasColumnName("TUniqueTrainKeyId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalTrainNumber).IsRequired();

                entity.Property(e => e.TrainNumber).IsRequired();

                entity.HasOne(d => d.ScopeValueNavigation)
                    .WithMany(p => p.TuniqueTrainKey)
                    .HasForeignKey(d => d.ScopeValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TUniqueTrainKey_TTrainScope");
            });

            modelBuilder.Entity<TusageType>(entity =>
            {
                entity.ToTable("TUsageType");

                entity.Property(e => e.TusageTypeId).HasColumnName("TUsageTypeId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<TvalidForMovements>(entity =>
            {
                entity.ToTable("TValidForMovements");

                entity.Property(e => e.TvalidForMovementsId)
                    .HasColumnName("TValidForMovementsId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Kind).IsRequired();
            });

            modelBuilder.Entity<TvalueTable>(entity =>
            {
                entity.ToTable("TValueTable");

                entity.Property(e => e.TvalueTableId)
                    .HasColumnName("TValueTableId")
                    .ValueGeneratedNever();

                entity.Property(e => e.XvalueName)
                    .IsRequired()
                    .HasColumnName("XValueName");

                entity.Property(e => e.XvalueUnit)
                    .IsRequired()
                    .HasColumnName("XValueUnit");

                entity.Property(e => e.YvalueName)
                    .IsRequired()
                    .HasColumnName("YValueName");

                entity.Property(e => e.YvalueUnit)
                    .IsRequired()
                    .HasColumnName("YValueUnit");

                entity.Property(e => e.ZvalueName)
                    .IsRequired()
                    .HasColumnName("ZValueName");

                entity.Property(e => e.ZvalueUnit)
                    .IsRequired()
                    .HasColumnName("ZValueUnit");

                entity.HasOne(d => d.ColumnHeaderNavigation)
                    .WithMany(p => p.TvalueTable)
                    .HasForeignKey(d => d.ColumnHeader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TValueTable_TValueTableColumnHeader");

                entity.HasOne(d => d.ValueLineNavigation)
                    .WithMany(p => p.TvalueTable)
                    .HasForeignKey(d => d.ValueLine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TValueTable_TValueTableValueLine");
            });

            modelBuilder.Entity<TvalueTableColumnHeader>(entity =>
            {
                entity.ToTable("TValueTableColumnHeader");

                entity.Property(e => e.TvalueTableColumnHeaderId)
                    .HasColumnName("TValueTableColumnHeaderId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Zvalue)
                    .HasColumnName("ZValue")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TvalueTableValueLine>(entity =>
            {
                entity.ToTable("TValueTableValueLine");

                entity.Property(e => e.TvalueTableValueLineId)
                    .HasColumnName("TValueTableValueLineId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Xvalue)
                    .HasColumnName("XValue")
                    .HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.ValuesNavigation)
                    .WithMany(p => p.TvalueTableValueLine)
                    .HasForeignKey(d => d.Values)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TValueTableValueLine_TValueTableValueLineValues");
            });

            modelBuilder.Entity<TvalueTableValueLineValues>(entity =>
            {
                entity.ToTable("TValueTableValueLineValues");

                entity.Property(e => e.TvalueTableValueLineValuesId)
                    .HasColumnName("TValueTableValueLineValuesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Yvalue)
                    .HasColumnName("YValue")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Tvehicle>(entity =>
            {
                entity.ToTable("TVehicle");

                entity.Property(e => e.TvehicleId)
                    .HasColumnName("TVehicleId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AxleLoadValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AxleSequence).IsRequired();

                entity.Property(e => e.BruttoAdhesionWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BruttoWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.LengthValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NettoAdhesionWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NettoWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumberDrivenAxles).IsRequired();

                entity.Property(e => e.NumberNonDrivenAxles).IsRequired();

                entity.Property(e => e.ResistanceFactorValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TareAdhesionWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TareWeightValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TowingSpeedValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TrackGaugeAlternativeValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TrackGaugeValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VehicleCategory).IsRequired();

                entity.Property(e => e.VehicleFamilyRef).IsRequired();
            });

            modelBuilder.Entity<TvehicleIdentification>(entity =>
            {
                entity.ToTable("TVehicleIdentification");

                entity.Property(e => e.TvehicleIdentificationId)
                    .HasColumnName("TVehicleIdentificationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode).IsRequired();

                entity.Property(e => e.UicIdentNumber).IsRequired();

                entity.Property(e => e.VehicleKeeperMarking).IsRequired();
            });

            modelBuilder.Entity<TvehicleManufacturer>(entity =>
            {
                entity.ToTable("TVehicleManufacturer");

                entity.Property(e => e.TvehicleManufacturerId)
                    .HasColumnName("TVehicleManufacturerId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TvehicleOperator>(entity =>
            {
                entity.ToTable("TVehicleOperator");

                entity.Property(e => e.TvehicleOperatorId)
                    .HasColumnName("TVehicleOperatorId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TvehicleRef>(entity =>
            {
                entity.ToTable("TVehicleRef");

                entity.Property(e => e.TvehicleRefId)
                    .HasColumnName("TVehicleRefId")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderNumber).IsRequired();

                entity.Property(e => e.VehicleCount).IsRequired();

                entity.Property(e => e.VehicleRef).IsRequired();
            });

            modelBuilder.Entity<TverbalCounter>(entity =>
            {
                entity.ToTable("TVerbalCounter");

                entity.Property(e => e.TverbalCounterId).HasColumnName("TVerbalCounterId");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Twagon>(entity =>
            {
                entity.ToTable("TWagon");

                entity.Property(e => e.TwagonId)
                    .HasColumnName("TWagonId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalRotationMassValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AuxiliaryPowerConsumptionValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BearingType).IsRequired();

                entity.Property(e => e.HeadShape).IsRequired();

                entity.Property(e => e.HeadSurfaceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.KinematicEnvelope).IsRequired();

                entity.Property(e => e.RotationMassFactorValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Twinding>(entity =>
            {
                entity.ToTable("TWinding");

                entity.Property(e => e.TwindingId)
                    .HasColumnName("TWindingId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyName).IsRequired();

                entity.Property(e => e.NominalCurrentValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NominalVoltageValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrimaryLeakageInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrimaryResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SecondaryLeakageInductanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SecondaryResistanceValue).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TransformationRatioValue).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.Property(e => e.TypeId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
