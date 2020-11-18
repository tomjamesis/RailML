CREATE TABLE [dbo].[ETimetablePeriod]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETimetablePeriodId]	SMALLINT		NOT NULL,
	[Holidays]			BIGINT		NOT NULL,

	CONSTRAINT [PK_ETimetablePeriodId] PRIMARY KEY CLUSTERED ([ETimetablePeriodId] ASC),
	CONSTRAINT [FK_ETimetablePeriod_EHolidays] FOREIGN KEY ([Holidays]) REFERENCES [dbo].[EHolidays] ([EHolidaysId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
