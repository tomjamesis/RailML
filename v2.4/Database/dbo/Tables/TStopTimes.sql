CREATE TABLE [dbo].[TStopTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStopTimesId]		BIGINT			NOT NULL,
	[MinimalTime]		NVARCHAR(MAX)	NOT NULL,
	[OperationalReserve]	NVARCHAR(MAX)	NOT NULL,
	[AdditionalReserve]NVARCHAR(MAX)	NOT NULL,
	[ShuntingTime]		NVARCHAR(MAX)	NOT NULL,
	[ClearanceTime]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStopTimesId] PRIMARY KEY CLUSTERED ([TStopTimesId] ASC)
);
