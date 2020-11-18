CREATE TABLE [dbo].[ETrackTopology]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackTopologyId]	BIGINT		NOT NULL,
	[TrackBegin]		SMALLINT		NOT NULL,
	[TrackEnd]			SMALLINT		NOT NULL,
	[MileageChanges]	BIGINT		NOT NULL,
	[Connections]		BIGINT		NOT NULL,
	[CrossSections]	BIGINT		NOT NULL,
	[Borders]			BIGINT		NOT NULL,

	CONSTRAINT [PK_ETrackTopologyId] PRIMARY KEY CLUSTERED ([ETrackTopologyId] ASC),
	CONSTRAINT [FK_ETrackTopology_ETrackBegin] FOREIGN KEY ([TrackBegin]) REFERENCES [dbo].[ETrackBegin] ([ETrackBeginId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackTopology_ETrackEnd] FOREIGN KEY ([TrackEnd]) REFERENCES [dbo].[ETrackEnd] ([ETrackEndId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackTopology_EMileageChanges] FOREIGN KEY ([MileageChanges]) REFERENCES [dbo].[EMileageChanges] ([EMileageChangesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackTopology_EConnections] FOREIGN KEY ([Connections]) REFERENCES [dbo].[EConnections] ([EConnectionsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackTopology_ECrossSections] FOREIGN KEY ([CrossSections]) REFERENCES [dbo].[ECrossSections] ([ECrossSectionsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackTopology_EBorder] FOREIGN KEY ([Borders]) REFERENCES [dbo].[EBorder] ([EBorderId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
