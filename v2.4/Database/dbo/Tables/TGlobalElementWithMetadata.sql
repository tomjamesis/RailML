CREATE TABLE [dbo].[TGlobalElementWithMetadata]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGlobalElementWithMetadataId]	SMALLINT			NOT NULL,
	[Metadata]						BIGINT			NOT NULL,
	[Version]						NVARCHAR(MAX)	NOT NULL,
	[Base]							NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TGlobalElementWithMetadataId] PRIMARY KEY CLUSTERED ([TGlobalElementWithMetadataId] ASC),
	CONSTRAINT [FK_TGlobalElementWithMetadata_ElementContainer] FOREIGN KEY ([Metadata]) REFERENCES [dbo].[ElementContainer] ([ElementContainerId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
