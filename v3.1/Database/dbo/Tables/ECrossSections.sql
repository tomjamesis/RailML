CREATE TABLE [dbo].[ECrossSections]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECrossSectionsId]	BIGINT		NOT NULL,
	[CrossSection]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ECrossSectionsId] PRIMARY KEY CLUSTERED ([ECrossSectionsId] ASC),
	CONSTRAINT [FK_ECrossSections_TCrossSection] FOREIGN KEY ([CrossSection]) REFERENCES [dbo].[TCrossSection] ([TCrossSectionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
