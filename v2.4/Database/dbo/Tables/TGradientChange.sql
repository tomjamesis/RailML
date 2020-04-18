CREATE TABLE [dbo].[TGradientChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGradientChangeId]			SMALLINT		NOT NULL,
	[Slope]						DECIMAL(18, 6)	NOT NULL,
	[TransitionLenghtValue]		DECIMAL(18, 6)	NOT NULL,
	[TransitionLenghtValueSpecified]	BIT			NOT NULL,
	[TransitionRadiusValue]		DECIMAL(18, 6)	NOT NULL,
	[TransitionRadiusValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TGradientChangeId] PRIMARY KEY CLUSTERED ([TGradientChangeId] ASC)
);
