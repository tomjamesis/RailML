CREATE TABLE [dbo].[EBlockPartSequence]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBlockPartSequenceId]	SMALLINT		NOT NULL,
	[BlockPartRef]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBlockPartSequenceId] PRIMARY KEY CLUSTERED ([EBlockPartSequenceId] ASC),
	CONSTRAINT [FK_EBlockPartSequence_TBlockPartRef] FOREIGN KEY ([BlockPartRef]) REFERENCES [dbo].[TBlockPartRef] ([TBlockPartRefId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
