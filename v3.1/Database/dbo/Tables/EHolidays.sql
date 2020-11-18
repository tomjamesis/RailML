CREATE TABLE [dbo].[EHolidays]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EHolidaysId]	BIGINT		NOT NULL,
	[Holiday]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EHolidaysId] PRIMARY KEY CLUSTERED ([EHolidaysId] ASC),
	CONSTRAINT [FK_EHolidays_THoliday] FOREIGN KEY ([Holiday]) REFERENCES [dbo].[THoliday] ([THolidayId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
