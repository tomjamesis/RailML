CREATE TABLE [dbo].[TTrainPartSequence]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainPartSequenceId]	BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[Sequence]				NVARCHAR(MAX)	NOT NULL,
	[PathStatus]			NVARCHAR(MAX)	NOT NULL,
	[CategoryRef]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainPartSequenceId] PRIMARY KEY CLUSTERED ([TTrainPartSequenceId] ASC)
);
