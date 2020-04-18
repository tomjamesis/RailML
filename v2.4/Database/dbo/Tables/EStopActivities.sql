CREATE TABLE [dbo].[EStopActivities]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStopActivitiesId]	BIGINT		NOT NULL,
	[StopActivity]		BIGINT		NOT NULL,

	CONSTRAINT [PK_EStopActivitiesId] PRIMARY KEY CLUSTERED ([EStopActivitiesId] ASC),
	CONSTRAINT [FK_EStopActivities_TStopActivity] FOREIGN KEY ([StopActivity]) REFERENCES [dbo].[TStopActivity] ([TStopActivityId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
