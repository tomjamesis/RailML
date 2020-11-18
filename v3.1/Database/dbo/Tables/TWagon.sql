CREATE TABLE [dbo].[TWagon]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TWagonId]								BIGINT			NOT NULL,
	[RotationMassFactorValue]				DECIMAL(18, 6)	NOT NULL,
	[RotationMassFactorValueSpecified]		BIT				NOT NULL,
	[AdditionalRotationMassValue]			DECIMAL(18, 6)	NOT NULL,
	[AdditionalRotationMassValueSpecified]	BIT				NOT NULL,
	[KinematicEnvelope]					NVARCHAR(MAX)	NOT NULL,
	[AuxiliaryPowerConsumptionValue]		DECIMAL(18, 6)	NOT NULL,
	[AuxiliaryPowerConsumptionValueSpecified]	BIT				NOT NULL,
	[HeadShape]							NVARCHAR(MAX)	NOT NULL,
	[HeadSurfaceValue]						DECIMAL(18, 6)	NOT NULL,
	[HeadSurfaceValueSpecified]			BIT				NOT NULL,
	[BearingType]							NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TWagonId] PRIMARY KEY CLUSTERED ([TWagonId] ASC)
);
