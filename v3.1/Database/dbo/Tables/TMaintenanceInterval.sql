CREATE TABLE [dbo].[TMaintenanceInterval]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMaintenanceIntervalId]				SMALLINT			NOT NULL,
	[MaximumIntervalDays]					NVARCHAR(MAX)	NOT NULL,
	[MaximumIntervalDistanceValue]			DECIMAL(18, 6)	NOT NULL,
	[MaximumIntervalDistanceValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TMaintenanceIntervalId] PRIMARY KEY CLUSTERED ([TMaintenanceIntervalId] ASC)
);
