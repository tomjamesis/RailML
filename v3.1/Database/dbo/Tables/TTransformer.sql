CREATE TABLE [dbo].[TTransformer]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTransformerId]					BIGINT			NOT NULL,
	[Count]							NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]						NVARCHAR(MAX)	NOT NULL,
	[FerrumResistanceValue]			DECIMAL(18, 6)	NOT NULL,
	[FerrumResistanceValueSpecified]	BIT				NOT NULL,
	[AdditionalResistanceValue]		DECIMAL(18, 6)	NOT NULL,
	[AdditionalResistanceValueSpecified]	BIT				NOT NULL,
	[MainInductanceValue]				DECIMAL(18, 6)	NOT NULL,
	[MainInductanceValueSpecified]		BIT				NOT NULL,
	[MeanEfficiencyValue]				DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]		BIT				NOT NULL,

	CONSTRAINT [PK_TTransformerId] PRIMARY KEY CLUSTERED ([TTransformerId] ASC)
);
