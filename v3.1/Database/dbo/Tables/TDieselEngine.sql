CREATE TABLE [dbo].[TDieselEngine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDieselEngineId]						BIGINT			NOT NULL,
	[Count]								NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]							NVARCHAR(MAX)	NOT NULL,
	[NominalPowerValue]					DECIMAL(18, 6)	NOT NULL,
	[NominalPowerValueSpecified]			BIT				NOT NULL,
	[AvailableAuxiliaryPowerValue]			DECIMAL(18, 6)	NOT NULL,
	[AvailableAuxiliaryPowerValueSpecified]	BIT				NOT NULL,
	[FuelCapacityValue]					DECIMAL(18, 6)	NOT NULL,
	[FuelCapacityValueSpecified]			BIT				NOT NULL,
	[MeanEfficiencyValue]					DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]			BIT				NOT NULL,

	CONSTRAINT [PK_TDieselEngineId] PRIMARY KEY CLUSTERED ([TDieselEngineId] ASC)
);
