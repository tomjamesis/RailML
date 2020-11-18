CREATE TABLE [dbo].[TElectrificationSystem]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElectrificationSystemId]	BIGINT		NOT NULL,
	[VoltageValue]				DECIMAL(18, 6)	NOT NULL,
	[VoltageValueSpecified]	BIT			NOT NULL,
	[FrequencyValue]			DECIMAL(18, 6)	NOT NULL,
	[FrequencyValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TElectrificationSystemId] PRIMARY KEY CLUSTERED ([TElectrificationSystemId] ASC)
);
