CREATE TABLE [dbo].[TGeoCoord]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGeoCoordId]				BIGINT			NOT NULL,
	[Coord]					BIGINT			NOT NULL,
	[ExtraHeightValue]			BIGINT			NOT NULL,
	[ExtraHeightValueSpecified]	BIT				NOT NULL,
	[EpsgCode]					NVARCHAR(MAX)	NOT NULL,
	[HeightEpsgCode]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TGeoCoordId] PRIMARY KEY CLUSTERED ([TGeoCoordId] ASC)
);
