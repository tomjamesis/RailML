CREATE TABLE [dbo].[TGear]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGearId]						BIGINT			NOT NULL,
	[Count]						NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]					NVARCHAR(MAX)	NOT NULL,
	[GearRatioValue]				DECIMAL(18, 6)	NOT NULL,
	[GearRatioValueSpecified]		BIT				NOT NULL,
	[MeanEfficiencyValue]			DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]	BIT				NOT NULL,
	[DesignType]					NVARCHAR(MAX)	NOT NULL,
	[ManufacturerName]				NVARCHAR(MAX)	NOT NULL,
	[NominalPowerValue]			DECIMAL(18, 6)	NOT NULL,
	[NominalPowerValueSpecified]	BIT				NOT NULL,
	[TorqueConversion]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TGearId] PRIMARY KEY CLUSTERED ([TGearId] ASC)
);
