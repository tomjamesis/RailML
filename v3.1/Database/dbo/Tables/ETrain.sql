CREATE TABLE [dbo].[ETrain]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainId]			SMALLINT		NOT NULL,
	[TrainPartSequence]	SMALLINT		NOT NULL,
	[TafTapTsiTrainID]	SMALLINT		NOT NULL,
	[Replacements]		BIGINT		NOT NULL,

	CONSTRAINT [PK_ETrainId] PRIMARY KEY CLUSTERED ([ETrainId] ASC),
	CONSTRAINT [FK_ETrain_ETrainPartSequence] FOREIGN KEY ([TrainPartSequence]) REFERENCES [dbo].[ETrainPartSequence] ([ETrainPartSequenceId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrain_ETapTsiTransportOperationalIdentifier] FOREIGN KEY ([TafTapTsiTrainID]) REFERENCES [dbo].[ETapTsiTransportOperationalIdentifier] ([ETapTsiTransportOperationalIdentifierId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrain_EReplacedTrains] FOREIGN KEY ([Replacements]) REFERENCES [dbo].[EReplacedTrains] ([EReplacedTrainsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
