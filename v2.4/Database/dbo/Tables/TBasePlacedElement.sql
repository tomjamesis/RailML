CREATE TABLE [dbo].[TBasePlacedElement]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBasePlacedElementId]		SMALLINT		NOT NULL,
	[GeoCoord]					BIGINT		NOT NULL,
	[Pos]						DECIMAL(18, 6)	NOT NULL,
	[AbsPosValue]				DECIMAL(18, 6)	NOT NULL,
	[AbsPosValueSpecified]		BIT			NOT NULL,
	[AbsPosOffsetValue]		DECIMAL(18, 6)	NOT NULL,
	[AbsPosOffsetValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TBasePlacedElementId] PRIMARY KEY CLUSTERED ([TBasePlacedElementId] ASC),
	CONSTRAINT [FK_TBasePlacedElement_TGeoCoord] FOREIGN KEY ([GeoCoord]) REFERENCES [dbo].[TGeoCoord] ([TGeoCoordId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
