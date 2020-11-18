CREATE TABLE [dbo].[TTimetablePeriod]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTimetablePeriodId]	SMALLINT		NOT NULL,
	[StartDateValue]		DATETIME		NOT NULL,
	[StartDateValueSpecified]	BIT			NOT NULL,
	[EndDateValue]			DATETIME		NOT NULL,
	[EndDateValueSpecified]BIT			NOT NULL,
	[StartTimeValue]		DATETIME		NOT NULL,
	[StartTimeValueSpecified]	BIT			NOT NULL,
	[EndTimeValue]			DATETIME		NOT NULL,
	[EndTimeValueSpecified]BIT			NOT NULL,

	CONSTRAINT [PK_TTimetablePeriodId] PRIMARY KEY CLUSTERED ([TTimetablePeriodId] ASC)
);
