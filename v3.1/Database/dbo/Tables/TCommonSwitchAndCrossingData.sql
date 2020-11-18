CREATE TABLE [dbo].[TCommonSwitchAndCrossingData]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCommonSwitchAndCrossingDataId]	SMALLINT			NOT NULL,
	[TrackContinueCourse]				NVARCHAR(MAX)	NOT NULL,
	[TrackContinueRadiusValue]			DECIMAL(18, 6)	NOT NULL,
	[TrackContinueRadiusValueSpecified]	BIT				NOT NULL,
	[NormalPosition]					NVARCHAR(MAX)	NOT NULL,
	[Model]							NVARCHAR(MAX)	NOT NULL,
	[LengthValue]						DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]				BIT				NOT NULL,
	[OcpStationRef]					NVARCHAR(MAX)	NOT NULL,
	[ControllerRef]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TCommonSwitchAndCrossingDataId] PRIMARY KEY CLUSTERED ([TCommonSwitchAndCrossingDataId] ASC)
);
