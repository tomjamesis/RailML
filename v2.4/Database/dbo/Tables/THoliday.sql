CREATE TABLE [dbo].[THoliday]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[THolidayId]BIGINT			NOT NULL,
	[HolidayDate]	DATETIME			NOT NULL,
	[Description]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_THolidayId] PRIMARY KEY CLUSTERED ([THolidayId] ASC)
);
