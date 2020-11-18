CREATE TABLE [dbo].[TFormationTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TFormationTTId]					BIGINT			NOT NULL,
	[Any]								VARCHAR(MAX)		NOT NULL,
	[FormationRef]						NVARCHAR(MAX)	NOT NULL,
	[WeightValue]						DECIMAL(18, 6)	NOT NULL,
	[WeightValueSpecified]				BIT				NOT NULL,
	[LoadValue]						DECIMAL(18, 6)	NOT NULL,
	[LoadValueSpecified]				BIT				NOT NULL,
	[LengthValue]						DECIMAL(18, 6)	NOT NULL,
	[LengthValueSpecified]				BIT				NOT NULL,
	[SpeedValue]						DECIMAL(18, 6)	NOT NULL,
	[SpeedValueSpecified]				BIT				NOT NULL,
	[TimetableLoadValue]				DECIMAL(18, 6)	NOT NULL,
	[TimetableLoadValueSpecified]		BIT				NOT NULL,
	[OrientationReversedValue]			BIT				NOT NULL,
	[OrientationReversedValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TFormationTTId] PRIMARY KEY CLUSTERED ([TFormationTTId] ASC)
);
