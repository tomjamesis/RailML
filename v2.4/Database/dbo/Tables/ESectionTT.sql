CREATE TABLE [dbo].[ESectionTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ESectionTTId]	SMALLINT		NOT NULL,
	[TrackRef]		SMALLINT		NOT NULL,
	[RunTimes]		BIGINT		NOT NULL,

	CONSTRAINT [PK_ESectionTTId] PRIMARY KEY CLUSTERED ([ESectionTTId] ASC),
	CONSTRAINT [FK_ESectionTT_TTrackRef] FOREIGN KEY ([TrackRef]) REFERENCES [dbo].[TTrackRef] ([TTrackRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ESectionTT_TRunTimes] FOREIGN KEY ([RunTimes]) REFERENCES [dbo].[TRunTimes] ([TRunTimesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
