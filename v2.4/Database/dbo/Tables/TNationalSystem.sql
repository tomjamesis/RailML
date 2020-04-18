CREATE TABLE [dbo].[TNationalSystem]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TNationalSystemId]		SMALLINT			NOT NULL,
	[OnBoardUnitID]			NVARCHAR(MAX)	NOT NULL,
	[SoftwareVersion]			NVARCHAR(MAX)	NOT NULL,
	[Type]						NVARCHAR(MAX)	NOT NULL,
	[TrainProtectionMedium]	TINYINT			NOT NULL,
	[TrainProtectionMonitoring]	TINYINT			NOT NULL,

	CONSTRAINT [PK_TNationalSystemId] PRIMARY KEY CLUSTERED ([TNationalSystemId] ASC),
	CONSTRAINT [FK_TNationalSystem_TTrainProtectionMedium] FOREIGN KEY ([TrainProtectionMedium]) REFERENCES [dbo].[TTrainProtectionMedium] ([TTrainProtectionMediumId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TNationalSystem_TTrainProtectionMonitoring] FOREIGN KEY ([TrainProtectionMonitoring]) REFERENCES [dbo].[TTrainProtectionMonitoring] ([TTrainProtectionMonitoringId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
