CREATE TABLE [dbo].[EOcsElements]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcsElementsId]		BIGINT			NOT NULL,
	[Signals]				BIGINT			NOT NULL,
	[TrainDetectionElements]BIGINT			NOT NULL,
	[Balises]				BIGINT			NOT NULL,
	[TrainProtectionElements]	BIGINT			NOT NULL,
	[StopPosts]			BIGINT			NOT NULL,
	[Derailers]			BIGINT			NOT NULL,
	[TrainRadioChanges]	BIGINT			NOT NULL,
	[Locks]				BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_EOcsElementsId] PRIMARY KEY CLUSTERED ([EOcsElementsId] ASC),
	CONSTRAINT [FK_EOcsElements_ESignals] FOREIGN KEY ([Signals]) REFERENCES [dbo].[ESignals] ([ESignalsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_ETrainDetectionElements] FOREIGN KEY ([TrainDetectionElements]) REFERENCES [dbo].[ETrainDetectionElements] ([ETrainDetectionElementsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_EBalises] FOREIGN KEY ([Balises]) REFERENCES [dbo].[EBalises] ([EBalisesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_ETrainProtectionElements] FOREIGN KEY ([TrainProtectionElements]) REFERENCES [dbo].[ETrainProtectionElements] ([ETrainProtectionElementsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_EStopPosts] FOREIGN KEY ([StopPosts]) REFERENCES [dbo].[EStopPosts] ([EStopPostsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_EDerailers] FOREIGN KEY ([Derailers]) REFERENCES [dbo].[EDerailers] ([EDerailersId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_ETrainRadioChanges] FOREIGN KEY ([TrainRadioChanges]) REFERENCES [dbo].[ETrainRadioChanges] ([ETrainRadioChangesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcsElements_ELocks] FOREIGN KEY ([Locks]) REFERENCES [dbo].[ELocks] ([ELocksId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
