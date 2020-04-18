CREATE TABLE [dbo].[TBridge]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBridgeId]			SMALLINT			NOT NULL,
	[Kind]					NVARCHAR(MAX)	NOT NULL,
	[MeterloadValue]		DECIMAL(18, 6)	NOT NULL,
	[MeterloadValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TBridgeId] PRIMARY KEY CLUSTERED ([TBridgeId] ASC)
);
