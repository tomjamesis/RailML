CREATE TABLE [dbo].[EGeoMappings]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGeoMappingsId]	BIGINT		NOT NULL,
	[GeoMapping]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EGeoMappingsId] PRIMARY KEY CLUSTERED ([EGeoMappingsId] ASC),
	CONSTRAINT [FK_EGeoMappings_TPlacedElement] FOREIGN KEY ([GeoMapping]) REFERENCES [dbo].[TPlacedElement] ([TPlacedElementId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
