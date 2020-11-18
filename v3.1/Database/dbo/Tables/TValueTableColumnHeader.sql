CREATE TABLE [dbo].[TValueTableColumnHeader]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TValueTableColumnHeaderId]	BIGINT		NOT NULL,
	[ZValue]					DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TValueTableColumnHeaderId] PRIMARY KEY CLUSTERED ([TValueTableColumnHeaderId] ASC)
);
