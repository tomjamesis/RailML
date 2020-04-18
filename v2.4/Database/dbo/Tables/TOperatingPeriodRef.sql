CREATE TABLE [dbo].[TOperatingPeriodRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperatingPeriodRefId]SMALLINT		NOT NULL,
	[StartDateValue]		DATETIME		NOT NULL,
	[StartDateValueSpecified]	BIT			NOT NULL,
	[EndDateValue]			DATETIME		NOT NULL,
	[EndDateValueSpecified]BIT			NOT NULL,

	CONSTRAINT [PK_TOperatingPeriodRefId] PRIMARY KEY CLUSTERED ([TOperatingPeriodRefId] ASC)
);
