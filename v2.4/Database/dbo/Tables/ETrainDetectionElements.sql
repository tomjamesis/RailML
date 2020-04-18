CREATE TABLE [dbo].[ETrainDetectionElements]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainDetectionElementsId]	BIGINT		NOT NULL,
	[TrainDetector]			SMALLINT		NOT NULL,
	[TrackCircuitBorder]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainDetectionElementsId] PRIMARY KEY CLUSTERED ([ETrainDetectionElementsId] ASC),
	CONSTRAINT [FK_ETrainDetectionElements_TTrainDetector] FOREIGN KEY ([TrainDetector]) REFERENCES [dbo].[TTrainDetector] ([TTrainDetectorId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainDetectionElements_TTrackCircuitBorder] FOREIGN KEY ([TrackCircuitBorder]) REFERENCES [dbo].[TTrackCircuitBorder] ([TTrackCircuitBorderId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
