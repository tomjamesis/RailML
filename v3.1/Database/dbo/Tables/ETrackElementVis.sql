CREATE TABLE [dbo].[ETrackElementVis]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackElementVisId]	SMALLINT		NOT NULL,
	[Position]			BIGINT		NOT NULL,

	CONSTRAINT [PK_ETrackElementVisId] PRIMARY KEY CLUSTERED ([ETrackElementVisId] ASC),
	CONSTRAINT [FK_ETrackElementVis_TPoint] FOREIGN KEY ([Position]) REFERENCES [dbo].[TPoint] ([TPointId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
