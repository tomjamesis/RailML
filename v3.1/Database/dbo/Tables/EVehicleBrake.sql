CREATE TABLE [dbo].[EVehicleBrake]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EVehicleBrakeId]				SMALLINT			NOT NULL,
	[LoadSwitchValue]				TINYINT			NOT NULL,
	[LoadSwitchValueSpecified]		BIT				NOT NULL,
	[AutoBrakePercentage]			NVARCHAR(MAX)	NOT NULL,
	[MaxAutoBrakeMassValue]		DECIMAL(18, 6)	NOT NULL,
	[MaxAutoBrakeMassValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_EVehicleBrakeId] PRIMARY KEY CLUSTERED ([EVehicleBrakeId] ASC),
	CONSTRAINT [FK_EVehicleBrake_TLoadSwitch] FOREIGN KEY ([LoadSwitchValue]) REFERENCES [dbo].[TLoadSwitch] ([TLoadSwitchId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
