CREATE TABLE [dbo].[TFourQuadrantChopper]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TFourQuadrantChopperId]			BIGINT			NOT NULL,
	[Count]							NVARCHAR(MAX)	NOT NULL,
	[AssemblyName]						NVARCHAR(MAX)	NOT NULL,
	[MeanPhiValue]						DECIMAL(18, 6)	NOT NULL,
	[MeanPhiValueSpecified]			BIT				NOT NULL,
	[MeanPhiRegenerationValue]			DECIMAL(18, 6)	NOT NULL,
	[MeanPhiRegenerationValueSpecified]	BIT				NOT NULL,
	[MeanEfficiencyValue]				DECIMAL(18, 6)	NOT NULL,
	[MeanEfficiencyValueSpecified]		BIT				NOT NULL,

	CONSTRAINT [PK_TFourQuadrantChopperId] PRIMARY KEY CLUSTERED ([TFourQuadrantChopperId] ASC)
);
