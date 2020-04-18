CREATE TABLE [dbo].[TTractionInverter]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTractionInverterId]			BIGINT			NOT NULL,
	[Count]						NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]					NVARCHAR(MAX)	NOT NULL,
	[MeanEfficiencyValue]			DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TTractionInverterId] PRIMARY KEY CLUSTERED ([TTractionInverterId] ASC)
);
