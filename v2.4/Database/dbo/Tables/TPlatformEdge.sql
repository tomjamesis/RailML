CREATE TABLE [dbo].[TPlatformEdge]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPlatformEdgeId]		SMALLINT			NOT NULL,
	[ParentPlatformEdgeRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TPlatformEdgeId] PRIMARY KEY CLUSTERED ([TPlatformEdgeId] ASC)
);
