CREATE TABLE [dbo].[TSignalLevelCrossing]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalLevelCrossingId]	SMALLINT			NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,
	[Ref]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalLevelCrossingId] PRIMARY KEY CLUSTERED ([TSignalLevelCrossingId] ASC)
);
