CREATE TABLE [dbo].[EPlatformEdges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPlatformEdgesId]	BIGINT		NOT NULL,
	[PlatformEdge]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EPlatformEdgesId] PRIMARY KEY CLUSTERED ([EPlatformEdgesId] ASC),
	CONSTRAINT [FK_EPlatformEdges_TPlatformEdge] FOREIGN KEY ([PlatformEdge]) REFERENCES [dbo].[TPlatformEdge] ([TPlatformEdgeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
