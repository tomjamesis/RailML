CREATE TABLE [dbo].[TStandardDeviationTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TStandardDeviationTimesId]	BIGINT			NOT NULL,
	[ArrivalDelay]				NVARCHAR(MAX)	NOT NULL,
	[DepartureDelay]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TStandardDeviationTimesId] PRIMARY KEY CLUSTERED ([TStandardDeviationTimesId] ASC)
);
