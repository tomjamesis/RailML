CREATE TABLE [dbo].[EOrganizationalUnitBinding]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOrganizationalUnitBindingId]	BIGINT			NOT NULL,
	[VehicleOperator]				BIGINT			NOT NULL,
	[Customer]						BIGINT			NOT NULL,
	[RailwayUndertaking]			BIGINT			NOT NULL,
	[OperationalUndertaking]		BIGINT			NOT NULL,
	[Concessionaire]				BIGINT			NOT NULL,
	[Contractor]					BIGINT			NOT NULL,
	[Any]							VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_EOrganizationalUnitBindingId] PRIMARY KEY CLUSTERED ([EOrganizationalUnitBindingId] ASC),
	CONSTRAINT [FK_EOrganizationalUnitBinding_TElementWithReference] FOREIGN KEY ([VehicleOperator]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
