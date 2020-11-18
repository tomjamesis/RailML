CREATE TABLE [dbo].[TFormation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TFormationId]				SMALLINT			NOT NULL,
	[FormationCount]			NVARCHAR(MAX)	NOT NULL,
	[LengthValue]				DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]		BIT				NOT NULL,
	[SpeedValue]				DECIMAL(18, 6)	NOT NULL,
	[SpeedValueSpecified]		BIT				NOT NULL,
	[WeightValue]				DECIMAL(18, 6)	NOT NULL,
	[WeightValueSpecified]		BIT				NOT NULL,
	[BruttoWeightValue]		DECIMAL(18, 6)	NOT NULL,
	[BruttoWeightValueSpecified]	BIT				NOT NULL,
	[NettoWeightValue]			DECIMAL(18, 6)	NOT NULL,
	[NettoWeightValueSpecified]BIT				NOT NULL,
	[TareWeightValue]			DECIMAL(18, 6)	NOT NULL,
	[TareWeightValueSpecified]	BIT				NOT NULL,
	[EtcsTrainCategory]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TFormationId] PRIMARY KEY CLUSTERED ([TFormationId] ASC)
);
