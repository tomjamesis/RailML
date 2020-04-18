CREATE TABLE [dbo].[ETrackVis]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackVisId]	SMALLINT		NOT NULL,
	[TrackElementVis]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrackVisId] PRIMARY KEY CLUSTERED ([ETrackVisId] ASC),
	CONSTRAINT [FK_ETrackVis_ETrackElementVis] FOREIGN KEY ([TrackElementVis]) REFERENCES [dbo].[ETrackElementVis] ([ETrackElementVisId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
