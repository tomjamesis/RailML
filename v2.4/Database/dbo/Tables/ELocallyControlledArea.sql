CREATE TABLE [dbo].[ELocallyControlledArea]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELocallyControlledAreaId]	SMALLINT		NOT NULL,
	[TrackRef]					SMALLINT		NOT NULL,
	[ControllerRef]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_ELocallyControlledAreaId] PRIMARY KEY CLUSTERED ([ELocallyControlledAreaId] ASC),
	CONSTRAINT [FK_ELocallyControlledArea_TTrackRefInGroup] FOREIGN KEY ([TrackRef]) REFERENCES [dbo].[TTrackRefInGroup] ([TTrackRefInGroupId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ELocallyControlledArea_TElementRefInGroup] FOREIGN KEY ([ControllerRef]) REFERENCES [dbo].[TElementRefInGroup] ([TElementRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
