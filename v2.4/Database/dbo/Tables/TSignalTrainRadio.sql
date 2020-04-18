CREATE TABLE [dbo].[TSignalTrainRadio]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalTrainRadioId]	SMALLINT			NOT NULL,
	[TrackConditionRef]NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalTrainRadioId] PRIMARY KEY CLUSTERED ([TSignalTrainRadioId] ASC)
);
