CREATE TABLE [dbo].[EMonitoring]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EMonitoringId]SMALLINT		NOT NULL,
	[Etcs]			SMALLINT		NOT NULL,
	[NationalSystem]	SMALLINT		NOT NULL,
	[TrainRadio]	SMALLINT		NOT NULL,
	[OtherEquipment]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EMonitoringId] PRIMARY KEY CLUSTERED ([EMonitoringId] ASC),
	CONSTRAINT [FK_EMonitoring_TNationalSystem] FOREIGN KEY ([NationalSystem]) REFERENCES [dbo].[TNationalSystem] ([TNationalSystemId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EMonitoring_ETrainRadio] FOREIGN KEY ([TrainRadio]) REFERENCES [dbo].[ETrainRadio] ([ETrainRadioId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EMonitoring_TOtherEquipment] FOREIGN KEY ([OtherEquipment]) REFERENCES [dbo].[TOtherEquipment] ([TOtherEquipmentId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EMonitoring_EETCS] FOREIGN KEY ([Etcs]) REFERENCES [dbo].[EETCS] ([EETCSId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
