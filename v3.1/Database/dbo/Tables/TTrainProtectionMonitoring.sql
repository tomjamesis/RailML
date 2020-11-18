CREATE TABLE [dbo].[TTrainProtectionMonitoring]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainProtectionMonitoringId]	TINYINT		NOT NULL,
	[Value]						NVARCHAR(12)	NOT NULL,

	CONSTRAINT [PK_TTrainProtectionMonitoringId] PRIMARY KEY CLUSTERED ([TTrainProtectionMonitoringId] ASC)
);
