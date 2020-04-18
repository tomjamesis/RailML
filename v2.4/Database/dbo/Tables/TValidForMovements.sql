CREATE TABLE [dbo].[TValidForMovements]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TValidForMovementsId]	BIGINT			NOT NULL,
	[Kind]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TValidForMovementsId] PRIMARY KEY CLUSTERED ([TValidForMovementsId] ASC)
);
