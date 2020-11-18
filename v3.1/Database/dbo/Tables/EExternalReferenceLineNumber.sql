CREATE TABLE [dbo].[EExternalReferenceLineNumber]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EExternalReferenceLineNumberId]	BIGINT			NOT NULL,
	[LineNumber]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_EExternalReferenceLineNumberId] PRIMARY KEY CLUSTERED ([EExternalReferenceLineNumberId] ASC)
);
