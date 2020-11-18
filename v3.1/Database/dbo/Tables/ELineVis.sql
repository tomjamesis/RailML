CREATE TABLE [dbo].[ELineVis]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELineVisId]	SMALLINT		NOT NULL,
	[TrackVis]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ELineVisId] PRIMARY KEY CLUSTERED ([ELineVisId] ASC),
	CONSTRAINT [FK_ELineVis_ETrackVis] FOREIGN KEY ([TrackVis]) REFERENCES [dbo].[ETrackVis] ([ETrackVisId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
