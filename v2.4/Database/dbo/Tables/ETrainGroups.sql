CREATE TABLE [dbo].[ETrainGroups]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainGroupsId]	BIGINT		NOT NULL,
	[TrainGroup]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainGroupsId] PRIMARY KEY CLUSTERED ([ETrainGroupsId] ASC),
	CONSTRAINT [FK_ETrainGroups_ETrainGroup] FOREIGN KEY ([TrainGroup]) REFERENCES [dbo].[ETrainGroup] ([ETrainGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
