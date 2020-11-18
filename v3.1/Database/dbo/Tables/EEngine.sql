CREATE TABLE [dbo].[EEngine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EEngineId]	SMALLINT		NOT NULL,
	[Propulsion]	SMALLINT		NOT NULL,
	[Pantograph]	SMALLINT		NOT NULL,
	[EnergyStorage]	SMALLINT		NOT NULL,
	[Monitoring]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EEngineId] PRIMARY KEY CLUSTERED ([EEngineId] ASC),
	CONSTRAINT [FK_EEngine_EPropulsion] FOREIGN KEY ([Propulsion]) REFERENCES [dbo].[EPropulsion] ([EPropulsionId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EEngine_EPantograph] FOREIGN KEY ([Pantograph]) REFERENCES [dbo].[EPantograph] ([EPantographId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EEngine_EStorage] FOREIGN KEY ([EnergyStorage]) REFERENCES [dbo].[EStorage] ([EStorageId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EEngine_EMonitoring] FOREIGN KEY ([Monitoring]) REFERENCES [dbo].[EMonitoring] ([EMonitoringId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
