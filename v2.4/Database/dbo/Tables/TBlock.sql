CREATE TABLE [dbo].[TBlock]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBlockId]			SMALLINT			NOT NULL,
	[BlockGroupNumber]	NVARCHAR(MAX)	NOT NULL,
	[FixedValue]		BIT				NOT NULL,
	[FixedValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TBlockId] PRIMARY KEY CLUSTERED ([TBlockId] ASC)
);
