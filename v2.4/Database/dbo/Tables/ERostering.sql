CREATE TABLE [dbo].[ERostering]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ERosteringId]	SMALLINT		NOT NULL,
	[BlockParts]	BIGINT		NOT NULL,
	[Blocks]		BIGINT		NOT NULL,
	[Circulations]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ERosteringId] PRIMARY KEY CLUSTERED ([ERosteringId] ASC),
	CONSTRAINT [FK_ERostering_EBlockParts] FOREIGN KEY ([BlockParts]) REFERENCES [dbo].[EBlockParts] ([EBlockPartsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ERostering_EBlocks] FOREIGN KEY ([Blocks]) REFERENCES [dbo].[EBlocks] ([EBlocksId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ERostering_ECirculations] FOREIGN KEY ([Circulations]) REFERENCES [dbo].[ECirculations] ([ECirculationsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
