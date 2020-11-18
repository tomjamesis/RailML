CREATE TABLE [dbo].[ETrainProtectionChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainProtectionChangesId]	BIGINT		NOT NULL,
	[TrainProtectionChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainProtectionChangesId] PRIMARY KEY CLUSTERED ([ETrainProtectionChangesId] ASC),
	CONSTRAINT [FK_ETrainProtectionChanges_TTrainProtectionChange] FOREIGN KEY ([TrainProtectionChange]) REFERENCES [dbo].[TTrainProtectionChange] ([TTrainProtectionChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
