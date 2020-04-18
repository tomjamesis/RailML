CREATE TABLE [dbo].[TAdditionalOcpName]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAdditionalOcpNameId]	BIGINT			NOT NULL,
	[Name]					NVARCHAR(MAX)	NOT NULL,
	[Description]			NVARCHAR(MAX)	NOT NULL,
	[Lang]					NVARCHAR(MAX)	NOT NULL,
	[Type]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TAdditionalOcpNameId] PRIMARY KEY CLUSTERED ([TAdditionalOcpNameId] ASC)
);
