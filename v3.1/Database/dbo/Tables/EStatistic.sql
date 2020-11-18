CREATE TABLE [dbo].[EStatistic]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStatisticId]		SMALLINT		NOT NULL,
	[Mean]				BIGINT		NOT NULL,
	[Median]			BIGINT		NOT NULL,
	[StandardDeviation]	BIGINT		NOT NULL,
	[StatisticAnalyses]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EStatisticId] PRIMARY KEY CLUSTERED ([EStatisticId] ASC),
	CONSTRAINT [FK_EStatistic_TStatisticAnalyses] FOREIGN KEY ([StatisticAnalyses]) REFERENCES [dbo].[TStatisticAnalyses] ([TStatisticAnalysesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStatistic_TStatisticTimes] FOREIGN KEY ([Mean]) REFERENCES [dbo].[TStatisticTimes] ([TStatisticTimesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EStatistic_TStandardDeviationTimes] FOREIGN KEY ([StandardDeviation]) REFERENCES [dbo].[TStandardDeviationTimes] ([TStandardDeviationTimesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
