CREATE TABLE [dbo].[TAttribute]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAttributeId]	BIGINT			NOT NULL,
	[Name]			NVARCHAR(MAX)	NOT NULL,
	[Value]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TAttributeId] PRIMARY KEY CLUSTERED ([TAttributeId] ASC)
);
