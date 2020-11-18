CREATE TABLE [dbo].[ETrainRadioChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainRadioChangesId]	BIGINT		NOT NULL,
	[TrainRadioChange]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainRadioChangesId] PRIMARY KEY CLUSTERED ([ETrainRadioChangesId] ASC),
	CONSTRAINT [FK_ETrainRadioChanges_TTrainRadioChange] FOREIGN KEY ([TrainRadioChange]) REFERENCES [dbo].[TTrainRadioChange] ([TTrainRadioChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
