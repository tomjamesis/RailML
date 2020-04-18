CREATE TABLE [dbo].[TTrainEngine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainEngineId]					BIGINT			NOT NULL,
	[TrainMeanAccelerationValue]		DECIMAL(18, 6)	NOT NULL,
	[TrainMeanAccelerationValueSpecified]	BIT				NOT NULL,
	[TrainMaxAccelerationValue]		DECIMAL(18, 6)	NOT NULL,
	[TrainMaxAccelerationValueSpecified]BIT				NOT NULL,
	[TrainMinTimeHoldSpeed]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainEngineId] PRIMARY KEY CLUSTERED ([TTrainEngineId] ASC)
);
