CREATE TABLE [dbo].[TAxleWeight]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAxleWeightId]		BIGINT		NOT NULL,
	[Value]				DECIMAL(18, 6)	NOT NULL,
	[MeterloadValue]		DECIMAL(18, 6)	NOT NULL,
	[MeterloadValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TAxleWeightId] PRIMARY KEY CLUSTERED ([TAxleWeightId] ASC)
);
