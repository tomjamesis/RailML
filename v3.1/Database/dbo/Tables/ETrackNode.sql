CREATE TABLE [dbo].[ETrackNode]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrackNodeId]	SMALLINT			NOT NULL,
	[Connection]	NVARCHAR(255)	NOT NULL,
	[BufferStop]	SMALLINT			NOT NULL,
	[OpenEnd]		SMALLINT			NOT NULL,
	[MacroscopicNode]	BIGINT			NOT NULL,

	CONSTRAINT [PK_ETrackNodeId] PRIMARY KEY CLUSTERED ([ETrackNodeId] ASC),
	CONSTRAINT [FK_ETrackNode_TConnectionData] FOREIGN KEY ([Connection]) REFERENCES [dbo].[TConnectionData] ([TConnectionDataId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackNode_TBufferStop] FOREIGN KEY ([BufferStop]) REFERENCES [dbo].[TBufferStop] ([TBufferStopId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackNode_TOpenEnd] FOREIGN KEY ([OpenEnd]) REFERENCES [dbo].[TOpenEnd] ([TOpenEndId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrackNode_TMacroscopicNode] FOREIGN KEY ([MacroscopicNode]) REFERENCES [dbo].[TMacroscopicNode] ([TMacroscopicNodeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
