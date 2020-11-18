CREATE TABLE [dbo].[TSignalLine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalLineId]	SMALLINT			NOT NULL,
	[Ref]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalLineId] PRIMARY KEY CLUSTERED ([TSignalLineId] ASC)
);
