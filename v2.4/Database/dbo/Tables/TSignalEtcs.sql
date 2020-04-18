CREATE TABLE [dbo].[TSignalEtcs]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalEtcsId]		SMALLINT			NOT NULL,
	[SrsVersion]			NVARCHAR(MAX)	NOT NULL,
	[Level_0Value]			BIT				NOT NULL,
	[Level_0ValueSpecified]	BIT				NOT NULL,
	[Level_1Value]			BIT				NOT NULL,
	[Level_1ValueSpecified]	BIT				NOT NULL,
	[Level_2Value]			BIT				NOT NULL,
	[Level_2ValueSpecified]	BIT				NOT NULL,
	[Level_3Value]			BIT				NOT NULL,
	[Level_3ValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TSignalEtcsId] PRIMARY KEY CLUSTERED ([TSignalEtcsId] ASC)
);
