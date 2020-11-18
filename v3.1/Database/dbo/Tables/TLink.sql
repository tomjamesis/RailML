CREATE TABLE [dbo].[TLink]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLinkId]		BIGINT		NOT NULL,
	[NominalVoltage]	DECIMAL(18, 6)	NOT NULL,
	[NominalCurrent]	DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TLinkId] PRIMARY KEY CLUSTERED ([TLinkId] ASC)
);
