CREATE TABLE [dbo].[TOperatingPeriod]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperatingPeriodId]	SMALLINT			NOT NULL,
	[TimetablePeriodRef]	NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,
	[BitMask]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOperatingPeriodId] PRIMARY KEY CLUSTERED ([TOperatingPeriodId] ASC)
);
