CREATE TABLE [dbo].[TGauge]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGaugeId]	BIGINT		NOT NULL,
	[Value]	DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TGaugeId] PRIMARY KEY CLUSTERED ([TGaugeId] ASC)
);
