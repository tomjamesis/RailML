CREATE TABLE [dbo].[EVehicleBrakes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EVehicleBrakesId]		BIGINT		NOT NULL,
	[VehicleBrake]			SMALLINT		NOT NULL,
	[VehicleBrakeOperation]	BIGINT		NOT NULL,
	[MechanicalBrakeEffort]	SMALLINT		NOT NULL,
	[EddyCurrentBrake]		BIGINT		NOT NULL,

	CONSTRAINT [PK_EVehicleBrakesId] PRIMARY KEY CLUSTERED ([EVehicleBrakesId] ASC),
	CONSTRAINT [FK_EVehicleBrakes_EVehicleBrake] FOREIGN KEY ([VehicleBrake]) REFERENCES [dbo].[EVehicleBrake] ([EVehicleBrakeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicleBrakes_TBasicBrakeOperation] FOREIGN KEY ([VehicleBrakeOperation]) REFERENCES [dbo].[TBasicBrakeOperation] ([TBasicBrakeOperationId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicleBrakes_TEffortCurve] FOREIGN KEY ([MechanicalBrakeEffort]) REFERENCES [dbo].[TEffortCurve] ([TEffortCurveId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EVehicleBrakes_TEddyCurrentBrake] FOREIGN KEY ([EddyCurrentBrake]) REFERENCES [dbo].[TEddyCurrentBrake] ([TEddyCurrentBrakeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
