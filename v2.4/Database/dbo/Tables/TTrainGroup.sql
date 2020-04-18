CREATE TABLE [dbo].[TTrainGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainGroupId]	SMALLINT			NOT NULL,
	[Type]			NVARCHAR(MAX)	NOT NULL,
	[TrainNumber]	NVARCHAR(MAX)	NOT NULL,
	[ProcessStatus]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainGroupId] PRIMARY KEY CLUSTERED ([TTrainGroupId] ASC)
);
