CREATE TABLE [dbo].[ETimetablePeriods]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETimetablePeriodsId]	BIGINT		NOT NULL,
	[TimetablePeriod]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETimetablePeriodsId] PRIMARY KEY CLUSTERED ([ETimetablePeriodsId] ASC),
	CONSTRAINT [FK_ETimetablePeriods_ETimetablePeriod] FOREIGN KEY ([TimetablePeriod]) REFERENCES [dbo].[ETimetablePeriod] ([ETimetablePeriodId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
