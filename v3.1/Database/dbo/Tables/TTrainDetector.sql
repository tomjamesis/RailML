CREATE TABLE [dbo].[TTrainDetector]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainDetectorId]					SMALLINT			NOT NULL,
	[DetectionObject]					NVARCHAR(MAX)	NOT NULL,
	[Medium]							NVARCHAR(MAX)	NOT NULL,
	[PosInTrackValue]					TINYINT			NOT NULL,
	[PosInTrackValueSpecified]			BIT				NOT NULL,
	[DirectionDetectionValue]			BIT				NOT NULL,
	[DirectionDetectionValueSpecified]	BIT				NOT NULL,
	[Model]							NVARCHAR(MAX)	NOT NULL,
	[AxleCountingValue]				BIT				NOT NULL,
	[AxleCountingValueSpecified]		BIT				NOT NULL,
	[OcpStationRef]					NVARCHAR(MAX)	NOT NULL,
	[ControllerRef]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainDetectorId] PRIMARY KEY CLUSTERED ([TTrainDetectorId] ASC),
	CONSTRAINT [FK_TTrainDetector_TPosInTrack] FOREIGN KEY ([PosInTrackValue]) REFERENCES [dbo].[TPosInTrack] ([TPosInTrackId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
