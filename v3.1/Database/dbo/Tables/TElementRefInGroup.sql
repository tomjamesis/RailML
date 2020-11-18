CREATE TABLE [dbo].[TElementRefInGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElementRefInGroupId]	SMALLINT			NOT NULL,
	[Sequence]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TElementRefInGroupId] PRIMARY KEY CLUSTERED ([TElementRefInGroupId] ASC)
);
