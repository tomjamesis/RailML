CREATE TABLE [dbo].[TElementWithIDAndNameWithoutAny]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElementWithIDAndNameWithoutAnyId]	NVARCHAR(255)	NOT NULL,
	[Code]								NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TElementWithIDAndNameWithoutAnyId] PRIMARY KEY CLUSTERED ([TElementWithIDAndNameWithoutAnyId] ASC)
);
