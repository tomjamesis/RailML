CREATE TABLE [dbo].[Timetable]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TimetableId]		SMALLINT		NOT NULL,
	[TimetablePeriods]	BIGINT		NOT NULL,
	[OperatingPeriods]	BIGINT		NOT NULL,
	[Categories]		BIGINT		NOT NULL,
	[Annotations]		BIGINT		NOT NULL,
	[TrainParts]		BIGINT		NOT NULL,
	[Trains]			BIGINT		NOT NULL,
	[TrainGroups]		BIGINT		NOT NULL,
	[Rosterings]		BIGINT		NOT NULL,

	CONSTRAINT [PK_TimetableId] PRIMARY KEY CLUSTERED ([TimetableId] ASC),
	CONSTRAINT [FK_Timetable_ETimetablePeriods] FOREIGN KEY ([TimetablePeriods]) REFERENCES [dbo].[ETimetablePeriods] ([ETimetablePeriodsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_EOperatingPeriods] FOREIGN KEY ([OperatingPeriods]) REFERENCES [dbo].[EOperatingPeriods] ([EOperatingPeriodsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_ECategories] FOREIGN KEY ([Categories]) REFERENCES [dbo].[ECategories] ([ECategoriesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_EAnnotations] FOREIGN KEY ([Annotations]) REFERENCES [dbo].[EAnnotations] ([EAnnotationsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_ETrainParts] FOREIGN KEY ([TrainParts]) REFERENCES [dbo].[ETrainParts] ([ETrainPartsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_ETrains] FOREIGN KEY ([Trains]) REFERENCES [dbo].[ETrains] ([ETrainsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_ETrainGroups] FOREIGN KEY ([TrainGroups]) REFERENCES [dbo].[ETrainGroups] ([ETrainGroupsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Timetable_ERosterings] FOREIGN KEY ([Rosterings]) REFERENCES [dbo].[ERosterings] ([ERosteringsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
