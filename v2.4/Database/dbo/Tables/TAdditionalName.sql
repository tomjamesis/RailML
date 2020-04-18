CREATE TABLE [dbo].[TAdditionalName]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAdditionalNameId]	BIGINT			NOT NULL,
	[Name]				NVARCHAR(MAX)	NOT NULL,
	[Description]		NVARCHAR(MAX)	NOT NULL,
	[Lang]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TAdditionalNameId] PRIMARY KEY CLUSTERED ([TAdditionalNameId] ASC)
);
