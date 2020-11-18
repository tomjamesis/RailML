CREATE TABLE [dbo].[TBlockPart]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBlockPartId]			SMALLINT			NOT NULL,
	[BeginValue]			DATETIME			NOT NULL,
	[BeginValueSpecified]	BIT				NOT NULL,
	[BeginDay]				NVARCHAR(MAX)	NOT NULL,
	[EndValue]				DATETIME			NOT NULL,
	[EndValueSpecified]	BIT				NOT NULL,
	[EndDay]				NVARCHAR(MAX)	NOT NULL,
	[StartOcpRef]			NVARCHAR(MAX)	NOT NULL,
	[EndOcpRef]			NVARCHAR(MAX)	NOT NULL,
	[TrainPartRef]			NVARCHAR(MAX)	NOT NULL,
	[OperatingPeriodRef]	NVARCHAR(MAX)	NOT NULL,
	[Mission]				NVARCHAR(MAX)	NOT NULL,
	[FixedValue]			BIT				NOT NULL,
	[FixedValueSpecified]	BIT				NOT NULL,
	[RunLengthValue]		DECIMAL(18, 6)	NOT NULL,
	[RunLengthValueSpecified]	BIT				NOT NULL,
	[VehicleRef]			NVARCHAR(MAX)	NOT NULL,
	[FormationRef]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBlockPartId] PRIMARY KEY CLUSTERED ([TBlockPartId] ASC)
);
