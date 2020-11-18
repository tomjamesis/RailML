CREATE TABLE [dbo].[TStatisticAnalyses]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStatisticAnalysesId]		BIGINT			NOT NULL,
	[Description]				NVARCHAR(MAX)	NOT NULL,
	[PercentageValue]			DECIMAL(18, 6)	NOT NULL,
	[PercentageValueSpecified]	BIT				NOT NULL,
	[Value]					NVARCHAR(MAX)	NOT NULL,
	[Figure]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStatisticAnalysesId] PRIMARY KEY CLUSTERED ([TStatisticAnalysesId] ASC)
);
