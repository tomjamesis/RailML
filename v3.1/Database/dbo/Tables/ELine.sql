CREATE TABLE [dbo].[ELine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELineId]	SMALLINT			NOT NULL,
	[LineDescr]	NVARCHAR(MAX)	NOT NULL,
	[TrackRef]	SMALLINT			NOT NULL,

	CONSTRAINT [PK_ELineId] PRIMARY KEY CLUSTERED ([ELineId] ASC),
	CONSTRAINT [FK_ELine_TTrackRefInGroup] FOREIGN KEY ([TrackRef]) REFERENCES [dbo].[TTrackRefInGroup] ([TTrackRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
