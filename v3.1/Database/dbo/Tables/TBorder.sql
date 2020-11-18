CREATE TABLE [dbo].[TBorder]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBorderId]	SMALLINT			NOT NULL,
	[Type]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBorderId] PRIMARY KEY CLUSTERED ([TBorderId] ASC)
);
