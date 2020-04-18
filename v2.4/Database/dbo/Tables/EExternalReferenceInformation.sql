CREATE TABLE [dbo].[EExternalReferenceInformation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EExternalReferenceInformationId]	BIGINT			NOT NULL,
	[Description]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_EExternalReferenceInformationId] PRIMARY KEY CLUSTERED ([EExternalReferenceInformationId] ASC)
);
