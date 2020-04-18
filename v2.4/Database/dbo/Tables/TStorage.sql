CREATE TABLE [dbo].[TStorage]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStorageId]						SMALLINT		NOT NULL,
	[MaximumCurrentCharging]			DECIMAL(18, 6)	NOT NULL,
	[MaximumCurrentDischarging]		DECIMAL(18, 6)	NOT NULL,
	[MaximumPowerCharging]				DECIMAL(18, 6)	NOT NULL,
	[MaximumPowerDischarging]			DECIMAL(18, 6)	NOT NULL,
	[MaximumChargingEnergy]			DECIMAL(18, 6)	NOT NULL,
	[ChargingEfficiencyValue]			DECIMAL(18, 6)	NOT NULL,
	[ChargingEfficiencyValueSpecified]	BIT			NOT NULL,
	[DischargingEfficiencyValue]		DECIMAL(18, 6)	NOT NULL,
	[DischargingEfficiencyValueSpecified]	BIT			NOT NULL,
	[MeanStorageEfficiencyValue]		DECIMAL(18, 6)	NOT NULL,
	[MeanStorageEfficiencyValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TStorageId] PRIMARY KEY CLUSTERED ([TStorageId] ASC)
);
