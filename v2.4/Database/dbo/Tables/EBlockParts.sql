CREATE TABLE [dbo].[EBlockParts]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBlockPartsId]	BIGINT			NOT NULL,
	[BlockPart]	SMALLINT			NOT NULL,
	[Any]			VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_EBlockPartsId] PRIMARY KEY CLUSTERED ([EBlockPartsId] ASC),
	CONSTRAINT [FK_EBlockParts_TBlockPart] FOREIGN KEY ([BlockPart]) REFERENCES [dbo].[TBlockPart] ([TBlockPartId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
