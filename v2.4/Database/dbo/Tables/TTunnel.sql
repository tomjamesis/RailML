CREATE TABLE [dbo].[TTunnel]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTunnelId]				SMALLINT			NOT NULL,
	[CrossSectionValue]		DECIMAL(18, 6)	NOT NULL,
	[CrossSectionValueSpecified]	BIT				NOT NULL,
	[Kind]						NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTunnelId] PRIMARY KEY CLUSTERED ([TTunnelId] ASC)
);
