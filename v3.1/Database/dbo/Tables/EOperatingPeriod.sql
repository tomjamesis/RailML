CREATE TABLE [dbo].[EOperatingPeriod]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperatingPeriodId]	SMALLINT		NOT NULL,
	[OperatingDay]		SMALLINT		NOT NULL,
	[SpecialService]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EOperatingPeriodId] PRIMARY KEY CLUSTERED ([EOperatingPeriodId] ASC),
	CONSTRAINT [FK_EOperatingPeriod_EOperatingDay] FOREIGN KEY ([OperatingDay]) REFERENCES [dbo].[EOperatingDay] ([EOperatingDayId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOperatingPeriod_TSpecialService] FOREIGN KEY ([SpecialService]) REFERENCES [dbo].[TSpecialService] ([TSpecialServiceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
