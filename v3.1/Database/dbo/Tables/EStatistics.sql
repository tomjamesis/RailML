CREATE TABLE [dbo].[EStatistics]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStatisticsId]	BIGINT		NOT NULL,
	[Statistic]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EStatisticsId] PRIMARY KEY CLUSTERED ([EStatisticsId] ASC),
	CONSTRAINT [FK_EStatistics_EStatistic] FOREIGN KEY ([Statistic]) REFERENCES [dbo].[EStatistic] ([EStatisticId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
