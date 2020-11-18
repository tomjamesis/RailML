CREATE TABLE [dbo].[EMaintenanceIntervals]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EMaintenanceIntervalsId]	BIGINT		NOT NULL,
	[MaintenanceInterval]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EMaintenanceIntervalsId] PRIMARY KEY CLUSTERED ([EMaintenanceIntervalsId] ASC),
	CONSTRAINT [FK_EMaintenanceIntervals_TMaintenanceInterval] FOREIGN KEY ([MaintenanceInterval]) REFERENCES [dbo].[TMaintenanceInterval] ([TMaintenanceIntervalId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
