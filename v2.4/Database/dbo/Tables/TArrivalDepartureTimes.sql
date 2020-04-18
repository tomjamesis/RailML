CREATE TABLE [dbo].[TArrivalDepartureTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TArrivalDepartureTimesId]	BIGINT			NOT NULL,
	[Scope]					NVARCHAR(MAX)	NOT NULL,
	[ArrivalValue]				DATETIME			NOT NULL,
	[ArrivalValueSpecified]	BIT				NOT NULL,
	[ArrivalDay]				NVARCHAR(MAX)	NOT NULL,
	[DepartureValue]			DATETIME			NOT NULL,
	[DepartureValueSpecified]	BIT				NOT NULL,
	[DepartureDay]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TArrivalDepartureTimesId] PRIMARY KEY CLUSTERED ([TArrivalDepartureTimesId] ASC)
);
