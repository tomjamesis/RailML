CREATE TABLE [dbo].[EOperatingPeriods]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperatingPeriodsId]	BIGINT		NOT NULL,
	[OperatingPeriod]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOperatingPeriodsId] PRIMARY KEY CLUSTERED ([EOperatingPeriodsId] ASC),
	CONSTRAINT [FK_EOperatingPeriods_EOperatingPeriod] FOREIGN KEY ([OperatingPeriod]) REFERENCES [dbo].[EOperatingPeriod] ([EOperatingPeriodId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
