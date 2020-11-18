CREATE TABLE [dbo].[EFormation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EFormationId]			SMALLINT		NOT NULL,
	[TrainOrder]			BIGINT		NOT NULL,
	[CategoryRef]			BIGINT		NOT NULL,
	[TrainEngine]			BIGINT		NOT NULL,
	[TrainBrakes]			BIGINT		NOT NULL,
	[TrainBrakeOperation]	BIGINT		NOT NULL,
	[TrainResistance]		SMALLINT		NOT NULL,
	[SpeedProfileRef]		BIGINT		NOT NULL,
	[TechnicalStopActivity]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EFormationId] PRIMARY KEY CLUSTERED ([EFormationId] ASC),
	CONSTRAINT [FK_EFormation_TElementWithReference] FOREIGN KEY ([CategoryRef]) REFERENCES [dbo].[TElementWithReference] ([TElementWithReferenceId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TBasicBrakeOperation] FOREIGN KEY ([TrainBrakeOperation]) REFERENCES [dbo].[TBasicBrakeOperation] ([TBasicBrakeOperationId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TSpeedProfileRefRS] FOREIGN KEY ([SpeedProfileRef]) REFERENCES [dbo].[TSpeedProfileRefRS] ([TSpeedProfileRefRSId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TTechnicalStopActivity] FOREIGN KEY ([TechnicalStopActivity]) REFERENCES [dbo].[TTechnicalStopActivity] ([TTechnicalStopActivityId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_ETrainOrder] FOREIGN KEY ([TrainOrder]) REFERENCES [dbo].[ETrainOrder] ([ETrainOrderId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TTrainEngine] FOREIGN KEY ([TrainEngine]) REFERENCES [dbo].[TTrainEngine] ([TTrainEngineId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TBasicBrakeType] FOREIGN KEY ([TrainBrakes]) REFERENCES [dbo].[TBasicBrakeType] ([TBasicBrakeTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFormation_TTrainResistance] FOREIGN KEY ([TrainResistance]) REFERENCES [dbo].[TTrainResistance] ([TTrainResistanceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
