CREATE TABLE [dbo].[TElementWithReference]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElementWithReferenceId]	BIGINT			NOT NULL,
	[Ref]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TElementWithReferenceId] PRIMARY KEY CLUSTERED ([TElementWithReferenceId] ASC)
);
