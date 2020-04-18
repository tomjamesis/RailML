CREATE TABLE [dbo].[ETrainProtectionElements]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainProtectionElementsId]BIGINT		NOT NULL,
	[TrainProtectionElement]	SMALLINT		NOT NULL,
	[TrainProtectionElementGroup]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainProtectionElementsId] PRIMARY KEY CLUSTERED ([ETrainProtectionElementsId] ASC),
	CONSTRAINT [FK_ETrainProtectionElements_TTrainProtectionElement] FOREIGN KEY ([TrainProtectionElement]) REFERENCES [dbo].[TTrainProtectionElement] ([TTrainProtectionElementId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainProtectionElements_TTrainProtectionElementGroup] FOREIGN KEY ([TrainProtectionElementGroup]) REFERENCES [dbo].[TTrainProtectionElementGroup] ([TTrainProtectionElementGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
