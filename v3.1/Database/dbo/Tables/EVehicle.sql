CREATE TABLE [dbo].[EVehicle]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EVehicleId]			SMALLINT		NOT NULL,
	[Classification]		BIGINT		NOT NULL,
	[Engine]				SMALLINT		NOT NULL,
	[Wagon]				SMALLINT		NOT NULL,
	[VehicleBrakes]		BIGINT		NOT NULL,
	[LoadLimitMatrix]		SMALLINT		NOT NULL,
	[CurvingLimitation]	SMALLINT		NOT NULL,
	[MaintenanceIntervals]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EVehicleId] PRIMARY KEY CLUSTERED ([EVehicleId] ASC),
	CONSTRAINT [FK_EVehicle_EClassification] FOREIGN KEY ([Classification]) REFERENCES [dbo].[EClassification] ([EClassificationId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_EEngine] FOREIGN KEY ([Engine]) REFERENCES [dbo].[EEngine] ([EEngineId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_EWagon] FOREIGN KEY ([Wagon]) REFERENCES [dbo].[EWagon] ([EWagonId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_EVehicleBrakes] FOREIGN KEY ([VehicleBrakes]) REFERENCES [dbo].[EVehicleBrakes] ([EVehicleBrakesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_ELoadLimitMatrix] FOREIGN KEY ([LoadLimitMatrix]) REFERENCES [dbo].[ELoadLimitMatrix] ([ELoadLimitMatrixId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_ECurvingLimitation] FOREIGN KEY ([CurvingLimitation]) REFERENCES [dbo].[ECurvingLimitation] ([ECurvingLimitationId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicle_EMaintenanceIntervals] FOREIGN KEY ([MaintenanceIntervals]) REFERENCES [dbo].[EMaintenanceIntervals] ([EMaintenanceIntervalsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
