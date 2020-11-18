CREATE TABLE [dbo].[TGaugeChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGaugeChangeId]	SMALLINT		NOT NULL,
	[Value]		DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TGaugeChangeId] PRIMARY KEY CLUSTERED ([TGaugeChangeId] ASC)
);
