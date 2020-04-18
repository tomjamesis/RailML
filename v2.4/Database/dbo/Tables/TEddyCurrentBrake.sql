CREATE TABLE [dbo].[TEddyCurrentBrake]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEddyCurrentBrakeId]	BIGINT		NOT NULL,
	[MaxPower]			DECIMAL(18, 6)	NOT NULL,
	[MaxEffort]		DECIMAL(18, 6)	NOT NULL,
	[MinSpeed]			DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TEddyCurrentBrakeId] PRIMARY KEY CLUSTERED ([TEddyCurrentBrakeId] ASC)
);
