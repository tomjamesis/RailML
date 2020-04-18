CREATE TABLE [dbo].[TTrackNode]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[GeoCoord]					BIGINT			NOT NULL,
	[TTrackNodeId]				NVARCHAR(255)	NOT NULL,
	[Pos]						DECIMAL(18, 6)	NOT NULL,
	[AbsPosValue]				DECIMAL(18, 6)	NOT NULL,
	[AbsPosValueSpecified]		BIT				NOT NULL,
	[AbsPosOffsetValue]		DECIMAL(18, 6)	NOT NULL,
	[AbsPosOffsetValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TTrackNodeId] PRIMARY KEY CLUSTERED ([TTrackNodeId] ASC),
	CONSTRAINT [FK_TTrackNode_TGeoCoord] FOREIGN KEY ([GeoCoord]) REFERENCES [dbo].[TGeoCoord] ([TGeoCoordId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
