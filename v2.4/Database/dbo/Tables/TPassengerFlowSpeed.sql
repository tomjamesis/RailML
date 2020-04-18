CREATE TABLE [dbo].[TPassengerFlowSpeed]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPassengerFlowSpeedId]		BIGINT		NOT NULL,
	[FlowSpeedValue]				DECIMAL(18, 6)	NOT NULL,
	[FlowSpeedValueSpecified]		BIT			NOT NULL,
	[PlatformHeightValue]			DECIMAL(18, 6)	NOT NULL,
	[PlatformHeightValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TPassengerFlowSpeedId] PRIMARY KEY CLUSTERED ([TPassengerFlowSpeedId] ASC)
);
