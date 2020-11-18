CREATE TABLE [dbo].[TCirculation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCirculationId]		BIGINT			NOT NULL,
	[BlockRef]				NVARCHAR(MAX)	NOT NULL,
	[StartDateValue]		DATETIME			NOT NULL,
	[StartDateValueSpecified]	BIT				NOT NULL,
	[EndDateValue]			DATETIME			NOT NULL,
	[EndDateValueSpecified]BIT				NOT NULL,
	[OperatingPeriodRef]	NVARCHAR(MAX)	NOT NULL,
	[RepeatCount]			NVARCHAR(MAX)	NOT NULL,
	[VehicleCounter]		NVARCHAR(MAX)	NOT NULL,
	[VehicleGroupCounter]	NVARCHAR(MAX)	NOT NULL,
	[NextBlockRef]			NVARCHAR(MAX)	NOT NULL,
	[NextOperatingPeriodRef]NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TCirculationId] PRIMARY KEY CLUSTERED ([TCirculationId] ASC)
);
