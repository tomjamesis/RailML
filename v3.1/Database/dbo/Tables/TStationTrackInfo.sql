CREATE TABLE [dbo].[TStationTrackInfo]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStationTrackInfoId]	BIGINT			NOT NULL,
	[OperatingPeriodRef]NVARCHAR(MAX)	NOT NULL,
	[Track]			NVARCHAR(MAX)	NOT NULL,
	[Platform]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStationTrackInfoId] PRIMARY KEY CLUSTERED ([TStationTrackInfoId] ASC)
);
