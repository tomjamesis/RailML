CREATE TABLE [dbo].[EArrivalDepartureTimes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EArrivalDepartureTimesId]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EArrivalDepartureTimesId] PRIMARY KEY CLUSTERED ([EArrivalDepartureTimesId] ASC)
);
