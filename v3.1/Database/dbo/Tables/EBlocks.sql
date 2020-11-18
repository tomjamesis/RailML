CREATE TABLE [dbo].[EBlocks]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBlocksId]	BIGINT		NOT NULL,
	[Block]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBlocksId] PRIMARY KEY CLUSTERED ([EBlocksId] ASC),
	CONSTRAINT [FK_EBlocks_EBlock] FOREIGN KEY ([Block]) REFERENCES [dbo].[EBlock] ([EBlockId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
