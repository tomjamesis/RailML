CREATE TABLE [dbo].[TBlockPartSequence]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBlockPartSequenceId]	BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[Sequence]				NVARCHAR(MAX)	NOT NULL,
	[DayOffset]			NVARCHAR(MAX)	NOT NULL,
	[PreProcessingTime]	NVARCHAR(MAX)	NOT NULL,
	[PostProcessingTime]	NVARCHAR(MAX)	NOT NULL,
	[BasicBlockRef]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBlockPartSequenceId] PRIMARY KEY CLUSTERED ([TBlockPartSequenceId] ASC)
);
