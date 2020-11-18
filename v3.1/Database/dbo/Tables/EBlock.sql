CREATE TABLE [dbo].[EBlock]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBlockId]			SMALLINT		NOT NULL,
	[BlockPartSequence]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBlockId] PRIMARY KEY CLUSTERED ([EBlockId] ASC),
	CONSTRAINT [FK_EBlock_EBlockPartSequence] FOREIGN KEY ([BlockPartSequence]) REFERENCES [dbo].[EBlockPartSequence] ([EBlockPartSequenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
