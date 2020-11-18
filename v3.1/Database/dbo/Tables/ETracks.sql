CREATE TABLE [dbo].[ETracks]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETracksId]	BIGINT		NOT NULL,
	[Track]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETracksId] PRIMARY KEY CLUSTERED ([ETracksId] ASC),
	CONSTRAINT [FK_ETracks_ETrack] FOREIGN KEY ([Track]) REFERENCES [dbo].[ETrack] ([ETrackId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
