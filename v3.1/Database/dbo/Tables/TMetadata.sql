CREATE TABLE [dbo].[TMetadata]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMetadataId]		SMALLINT		NOT NULL,
	[OrganizationalUnits]	BIGINT		NOT NULL,

	CONSTRAINT [PK_TMetadataId] PRIMARY KEY CLUSTERED ([TMetadataId] ASC),
	CONSTRAINT [FK_TMetadata_TOrganizationalUnits] FOREIGN KEY ([OrganizationalUnits]) REFERENCES [dbo].[TOrganizationalUnits] ([TOrganizationalUnitsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
