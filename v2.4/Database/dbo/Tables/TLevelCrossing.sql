CREATE TABLE [dbo].[TLevelCrossing]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TLevelCrossingId]		SMALLINT			NOT NULL,
	[LengthValue]			DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]	BIT				NOT NULL,
	[AngleValue]			DECIMAL(18, 6)	NOT NULL,
	[AngleValueSpecified]	BIT				NOT NULL,
	[Protection]			NVARCHAR(MAX)	NOT NULL,
	[OcpStationRef]		NVARCHAR(MAX)	NOT NULL,
	[ControllerRef]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TLevelCrossingId] PRIMARY KEY CLUSTERED ([TLevelCrossingId] ASC)
);
