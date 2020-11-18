CREATE TABLE [dbo].[TSignalGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalGroupId]	SMALLINT			NOT NULL,
	[Type]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalGroupId] PRIMARY KEY CLUSTERED ([TSignalGroupId] ASC)
);
