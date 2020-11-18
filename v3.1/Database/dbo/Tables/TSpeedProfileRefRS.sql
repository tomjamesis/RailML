CREATE TABLE [dbo].[TSpeedProfileRefRS]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpeedProfileRefRSId]	BIGINT			NOT NULL,
	[Ref]					NVARCHAR(MAX)	NOT NULL,
	[Name]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSpeedProfileRefRSId] PRIMARY KEY CLUSTERED ([TSpeedProfileRefRSId] ASC)
);
