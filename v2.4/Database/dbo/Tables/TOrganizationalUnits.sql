CREATE TABLE [dbo].[TOrganizationalUnits]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOrganizationalUnitsId]	BIGINT		NOT NULL,
	[InfrastructureManager]SMALLINT		NOT NULL,
	[VehicleManufacturer]	SMALLINT		NOT NULL,
	[VehicleOperator]		SMALLINT		NOT NULL,
	[Customer]				SMALLINT		NOT NULL,
	[RailwayUndertaking]	SMALLINT		NOT NULL,
	[OperationalUndertaking]	SMALLINT		NOT NULL,
	[Concessionaire]		SMALLINT		NOT NULL,
	[Contractor]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_TOrganizationalUnitsId] PRIMARY KEY CLUSTERED ([TOrganizationalUnitsId] ASC),
	CONSTRAINT [FK_TOrganizationalUnits_TInfrastructureManager] FOREIGN KEY ([InfrastructureManager]) REFERENCES [dbo].[TInfrastructureManager] ([TInfrastructureManagerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TVehicleManufacturer] FOREIGN KEY ([VehicleManufacturer]) REFERENCES [dbo].[TVehicleManufacturer] ([TVehicleManufacturerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TVehicleOperator] FOREIGN KEY ([VehicleOperator]) REFERENCES [dbo].[TVehicleOperator] ([TVehicleOperatorId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TCustomer] FOREIGN KEY ([Customer]) REFERENCES [dbo].[TCustomer] ([TCustomerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TRailwayUndertaking] FOREIGN KEY ([RailwayUndertaking]) REFERENCES [dbo].[TRailwayUndertaking] ([TRailwayUndertakingId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TOperationalUndertaking] FOREIGN KEY ([OperationalUndertaking]) REFERENCES [dbo].[TOperationalUndertaking] ([TOperationalUndertakingId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TConcessionaire] FOREIGN KEY ([Concessionaire]) REFERENCES [dbo].[TConcessionaire] ([TConcessionaireId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TOrganizationalUnits_TContractor] FOREIGN KEY ([Contractor]) REFERENCES [dbo].[TContractor] ([TContractorId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
