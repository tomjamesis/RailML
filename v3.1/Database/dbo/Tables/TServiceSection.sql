CREATE TABLE [dbo].[TServiceSection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TServiceSectionId]			SMALLINT			NOT NULL,
	[ParentServiceSectionRef]		NVARCHAR(MAX)	NOT NULL,
	[RampValue]					BIT				NOT NULL,
	[RampValueSpecified]			BIT				NOT NULL,
	[MaintenanceValue]				BIT				NOT NULL,
	[MaintenanceValueSpecified]	BIT				NOT NULL,
	[LoadingFacilityValue]			BIT				NOT NULL,
	[LoadingFacilityValueSpecified]	BIT				NOT NULL,
	[CleaningValue]				BIT				NOT NULL,
	[CleaningValueSpecified]		BIT				NOT NULL,
	[FuelingValue]					BIT				NOT NULL,
	[FuelingValueSpecified]		BIT				NOT NULL,
	[ParkingValue]					BIT				NOT NULL,
	[ParkingValueSpecified]		BIT				NOT NULL,
	[PreheatingValue]				BIT				NOT NULL,
	[PreheatingValueSpecified]		BIT				NOT NULL,

	CONSTRAINT [PK_TServiceSectionId] PRIMARY KEY CLUSTERED ([TServiceSectionId] ASC)
);
