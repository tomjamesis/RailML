CREATE TABLE [dbo].[TPoint]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPointId]	BIGINT		NOT NULL,
	[X]		BIGINT		NOT NULL,
	[Y]		BIGINT		NOT NULL,

	CONSTRAINT [PK_TPointId] PRIMARY KEY CLUSTERED ([TPointId] ASC)
);
