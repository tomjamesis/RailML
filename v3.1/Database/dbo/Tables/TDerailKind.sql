CREATE TABLE [dbo].[TDerailKind]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDerailKindId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(17)	NOT NULL,

	CONSTRAINT [PK_TDerailKindId] PRIMARY KEY CLUSTERED ([TDerailKindId] ASC)
);
