CREATE TABLE [dbo].[TTrainProtectionChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionChangeId]	SMALLINT		NOT NULL,
	[Monitoring]				TINYINT		NOT NULL,
	[MediumValue]				TINYINT		NOT NULL,
	[MediumValueSpecified]		BIT			NOT NULL,

	CONSTRAINT [PK_TTrainProtectionChangeId] PRIMARY KEY CLUSTERED ([TTrainProtectionChangeId] ASC),
	CONSTRAINT [FK_TTrainProtectionChange_TTrainProtectionMonitoring] FOREIGN KEY ([Monitoring]) REFERENCES [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TTrainProtectionChange_TTrainProtectionMedium] FOREIGN KEY ([MediumValue]) REFERENCES [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
