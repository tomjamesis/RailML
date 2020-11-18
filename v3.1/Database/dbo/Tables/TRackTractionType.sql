CREATE TABLE [dbo].[TRackTractionType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRackTractionTypeId]	BIGINT			NOT NULL,
	[Number]			NVARCHAR(MAX)	NOT NULL,
	[RackSystem]		NVARCHAR(MAX)	NOT NULL,
	[ResilentCogWheel]	BIT				NOT NULL,

	CONSTRAINT [PK_TRackTractionTypeId] PRIMARY KEY CLUSTERED ([TRackTractionTypeId] ASC)
);
