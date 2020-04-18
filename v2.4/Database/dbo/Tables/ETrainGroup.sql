CREATE TABLE [dbo].[ETrainGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainGroupId]	SMALLINT		NOT NULL,
	[TrainRef]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainGroupId] PRIMARY KEY CLUSTERED ([ETrainGroupId] ASC),
	CONSTRAINT [FK_ETrainGroup_TElementRefInGroup] FOREIGN KEY ([TrainRef]) REFERENCES [dbo].[TElementRefInGroup] ([TElementRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
