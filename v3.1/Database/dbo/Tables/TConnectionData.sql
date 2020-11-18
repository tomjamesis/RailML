CREATE TABLE [dbo].[TConnectionData]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TConnectionDataId]	NVARCHAR(255)	NOT NULL,
	[Ref]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TConnectionDataId] PRIMARY KEY CLUSTERED ([TConnectionDataId] ASC)
);
