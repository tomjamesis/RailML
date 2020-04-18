CREATE TABLE [dbo].[TStatisticTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStatisticTimesId]	BIGINT			NOT NULL,
	[ArrivalValue]			DATETIME			NOT NULL,
	[ArrivalValueSpecified]BIT				NOT NULL,
	[ArrivalDay]			NVARCHAR(MAX)	NOT NULL,
	[DepartureValue]		DATETIME			NOT NULL,
	[DepartureValueSpecified]	BIT				NOT NULL,
	[DepartureDay]			NVARCHAR(MAX)	NOT NULL,
	[ArrivalDelay]			NVARCHAR(MAX)	NOT NULL,
	[DepartureDelay]		NVARCHAR(MAX)	NOT NULL,
	[StopTime]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStatisticTimesId] PRIMARY KEY CLUSTERED ([TStatisticTimesId] ASC)
);
