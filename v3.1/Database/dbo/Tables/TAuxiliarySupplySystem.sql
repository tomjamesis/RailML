CREATE TABLE [dbo].[TAuxiliarySupplySystem]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAuxiliarySupplySystemId]	BIGINT		NOT NULL,
	[VoltageValue]				DECIMAL(18, 6)	NOT NULL,
	[VoltageValueSpecified]	BIT			NOT NULL,
	[FrequencyValue]			DECIMAL(18, 6)	NOT NULL,
	[FrequencyValueSpecified]	BIT			NOT NULL,
	[MaxPower]					DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TAuxiliarySupplySystemId] PRIMARY KEY CLUSTERED ([TAuxiliarySupplySystemId] ASC)
);
