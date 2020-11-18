CREATE TABLE [dbo].[ETrack]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackId]			SMALLINT			NOT NULL,
	[TrackDescr]		NVARCHAR(MAX)	NOT NULL,
	[TrackTopology]	BIGINT			NOT NULL,
	[TrackElements]	BIGINT			NOT NULL,
	[OcsElements]		BIGINT			NOT NULL,
	[InfraAttrGroupRefs]	BIGINT			NOT NULL,
	[Any]				VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_ETrackId] PRIMARY KEY CLUSTERED ([ETrackId] ASC),
	CONSTRAINT [FK_ETrack_ETrackTopology] FOREIGN KEY ([TrackTopology]) REFERENCES [dbo].[ETrackTopology] ([ETrackTopologyId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrack_ETrackElements] FOREIGN KEY ([TrackElements]) REFERENCES [dbo].[ETrackElements] ([ETrackElementsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrack_EOcsElements] FOREIGN KEY ([OcsElements]) REFERENCES [dbo].[EOcsElements] ([EOcsElementsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrack_EInfraAttrGroupRefs] FOREIGN KEY ([InfraAttrGroupRefs]) REFERENCES [dbo].[EInfraAttrGroupRefs] ([EInfraAttrGroupRefsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
