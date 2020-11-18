CREATE TABLE [dbo].[TStatistic]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStatisticId]	BIGINT			NOT NULL,
	[Any]			VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_TStatisticId] PRIMARY KEY CLUSTERED ([TStatisticId] ASC)
);
