CREATE TABLE [dbo].[TTrainResistance]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainResistanceId]				SMALLINT		NOT NULL,
	[TunnelFactorValue]				DECIMAL(18, 6)	NOT NULL,
	[TunnelFactorValueSpecified]		BIT			NOT NULL,
	[StrahlFactorValue]				DECIMAL(18, 6)	NOT NULL,
	[StrahlFactorValueSpecified]		BIT			NOT NULL,
	[DaviesMassDependentValue]			BIT			NOT NULL,
	[DaviesMassDependentValueSpecified]	BIT			NOT NULL,
	[DaviesFactorAValue]				DECIMAL(18, 6)	NOT NULL,
	[DaviesFactorAValueSpecified]		BIT			NOT NULL,
	[DaviesFactorBValue]				DECIMAL(18, 6)	NOT NULL,
	[DaviesFactorBValueSpecified]		BIT			NOT NULL,
	[DaviesFactorCValue]				DECIMAL(18, 6)	NOT NULL,
	[DaviesFactorCValueSpecified]		BIT			NOT NULL,

	CONSTRAINT [PK_TTrainResistanceId] PRIMARY KEY CLUSTERED ([TTrainResistanceId] ASC)
);
