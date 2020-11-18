CREATE TABLE [dbo].[TWinding]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TWindingId]								BIGINT			NOT NULL,
	[AssemblyName]								NVARCHAR(MAX)	NOT NULL,
	[NominalVoltageValue]						DECIMAL(18, 6)	NOT NULL,
	[NominalVoltageValueSpecified]				BIT				NOT NULL,
	[NominalCurrentValue]						DECIMAL(18, 6)	NOT NULL,
	[NominalCurrentValueSpecified]				BIT				NOT NULL,
	[TransformationRatioValue]					DECIMAL(18, 6)	NOT NULL,
	[TransformationRatioValueSpecified]		BIT				NOT NULL,
	[PrimaryResistanceValue]					DECIMAL(18, 6)	NOT NULL,
	[PrimaryResistanceValueSpecified]			BIT				NOT NULL,
	[SecondaryResistanceValue]					DECIMAL(18, 6)	NOT NULL,
	[SecondaryResistanceValueSpecified]		BIT				NOT NULL,
	[PrimaryLeakageInductanceValue]			DECIMAL(18, 6)	NOT NULL,
	[PrimaryLeakageInductanceValueSpecified]	BIT				NOT NULL,
	[SecondaryLeakageInductanceValue]			DECIMAL(18, 6)	NOT NULL,
	[SecondaryLeakageInductanceValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TWindingId] PRIMARY KEY CLUSTERED ([TWindingId] ASC)
);
