CREATE TABLE [dbo].[ETrackConditions]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackConditionsId]	BIGINT		NOT NULL,
	[TrackCondition]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrackConditionsId] PRIMARY KEY CLUSTERED ([ETrackConditionsId] ASC),
	CONSTRAINT [FK_ETrackConditions_TTrackCondition] FOREIGN KEY ([TrackCondition]) REFERENCES [dbo].[TTrackCondition] ([TTrackConditionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
