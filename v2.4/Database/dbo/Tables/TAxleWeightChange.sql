CREATE TABLE [dbo].[TAxleWeightChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAxleWeightChangeId]	SMALLINT		NOT NULL,
	[Value]				DECIMAL(18, 6)	NOT NULL,
	[MeterloadValue]		DECIMAL(18, 6)	NOT NULL,
	[MeterloadValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TAxleWeightChangeId] PRIMARY KEY CLUSTERED ([TAxleWeightChangeId] ASC)
);
