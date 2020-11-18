CREATE TABLE [dbo].[TOperatingDayDeviance]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperatingDayDevianceId]	BIGINT			NOT NULL,
	[OperatingCode]		NVARCHAR(MAX)	NOT NULL,
	[OnRequestValue]		BIT				NOT NULL,
	[OnRequestValueSpecified]	BIT				NOT NULL,
	[HolidayOffset]		NVARCHAR(MAX)	NOT NULL,
	[Ranking]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOperatingDayDevianceId] PRIMARY KEY CLUSTERED ([TOperatingDayDevianceId] ASC)
);
