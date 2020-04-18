CREATE TABLE [dbo].[TTrainProtection]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionId]	BIGINT		NOT NULL,
	[Monitoring]			TINYINT		NOT NULL,
	[MediumValue]			TINYINT		NOT NULL,
	[MediumValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TTrainProtectionId] PRIMARY KEY CLUSTERED ([TTrainProtectionId] ASC),
	CONSTRAINT [FK_TTrainProtection_TTrainProtectionMonitoring] FOREIGN KEY ([Monitoring]) REFERENCES [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TTrainProtection_TTrainProtectionMedium] FOREIGN KEY ([MediumValue]) REFERENCES [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
