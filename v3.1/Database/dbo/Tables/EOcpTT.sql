CREATE TABLE [dbo].[EOcpTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcpTTId]		SMALLINT			NOT NULL,
	[Times]		SMALLINT			NOT NULL,
	[Connections]	BIGINT			NOT NULL,
	[Statistics]	BIGINT			NOT NULL,
	[SectionTT]	SMALLINT			NOT NULL,
	[StopDescription]	SMALLINT			NOT NULL,
	[Any]			VARCHAR(MAX)		NOT NULL,

	CONSTRAINT [PK_EOcpTTId] PRIMARY KEY CLUSTERED ([EOcpTTId] ASC),
	CONSTRAINT [FK_EOcpTT_EArrivalDepartureTimes] FOREIGN KEY ([Times]) REFERENCES [dbo].[EArrivalDepartureTimes] ([EArrivalDepartureTimesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpTT_EConnectionsTT] FOREIGN KEY ([Connections]) REFERENCES [dbo].[EConnectionsTT] ([EConnectionsTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpTT_EStatistics] FOREIGN KEY ([Statistics]) REFERENCES [dbo].[EStatistics] ([EStatisticsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpTT_ESectionTT] FOREIGN KEY ([SectionTT]) REFERENCES [dbo].[ESectionTT] ([ESectionTTId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpTT_EStopDescription] FOREIGN KEY ([StopDescription]) REFERENCES [dbo].[EStopDescription] ([EStopDescriptionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
