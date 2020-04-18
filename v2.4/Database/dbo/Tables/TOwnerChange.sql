CREATE TABLE [dbo].[TOwnerChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOwnerChangeId]			SMALLINT			NOT NULL,
	[OwnerName]				NVARCHAR(MAX)	NOT NULL,
	[Uic_No]					NVARCHAR(MAX)	NOT NULL,
	[InfrastructureManagerRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOwnerChangeId] PRIMARY KEY CLUSTERED ([TOwnerChangeId] ASC)
);
