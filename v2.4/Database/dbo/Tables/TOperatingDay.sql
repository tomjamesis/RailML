CREATE TABLE [dbo].[TOperatingDay]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperatingDayId]		BIGINT			NOT NULL,
	[Any]					VARCHAR(MAX)		NOT NULL,
	[OperatingCode]		NVARCHAR(MAX)	NOT NULL,
	[OnRequestValue]		BIT				NOT NULL,
	[OnRequestValueSpecified]	BIT				NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TOperatingDayId] PRIMARY KEY CLUSTERED ([TOperatingDayId] ASC)
);
