CREATE TABLE [dbo].[TLocation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLocationId]				BIGINT			NOT NULL,
	[GeoCoord]					BIGINT			NOT NULL,
	[OcpRef]					NVARCHAR(MAX)	NOT NULL,
	[Pos]						DECIMAL(18, 6)	NOT NULL,
	[AbsPosValue]				DECIMAL(18, 6)	NOT NULL,
	[AbsPosValueSpecified]		BIT				NOT NULL,
	[AbsPosOffsetValue]		DECIMAL(18, 6)	NOT NULL,
	[AbsPosOffsetValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TLocationId] PRIMARY KEY CLUSTERED ([TLocationId] ASC),
	CONSTRAINT [FK_TLocation_TGeoCoord] FOREIGN KEY ([GeoCoord]) REFERENCES [dbo].[TGeoCoord] ([TGeoCoordId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
