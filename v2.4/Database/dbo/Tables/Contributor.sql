CREATE TABLE [dbo].[Contributor]
(
	--From MergedXSDs XSD
	--From 'Dc_Elements' Namespace
	[ContributorId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ContributorId] PRIMARY KEY CLUSTERED ([ContributorId] ASC)
);
