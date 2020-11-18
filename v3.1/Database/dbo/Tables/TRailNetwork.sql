CREATE TABLE [dbo].[TRailNetwork]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRailNetworkId]	BIGINT			NOT NULL,
	[Name]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRailNetworkId] PRIMARY KEY CLUSTERED ([TRailNetworkId] ASC)
);
