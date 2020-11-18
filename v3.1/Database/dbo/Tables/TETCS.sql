CREATE TABLE [dbo].[TETCS]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TETCSId]				SMALLINT			NOT NULL,
	[OnBoardUnitID]		NVARCHAR(MAX)	NOT NULL,
	[SoftwareVersion]		NVARCHAR(MAX)	NOT NULL,
	[SrsVersion]			NVARCHAR(MAX)	NOT NULL,
	[Level_0Value]			BIT				NOT NULL,
	[Level_0ValueSpecified]	BIT				NOT NULL,
	[Level_1Value]			BIT				NOT NULL,
	[Level_1ValueSpecified]	BIT				NOT NULL,
	[Level_2Value]			BIT				NOT NULL,
	[Level_2ValueSpecified]	BIT				NOT NULL,
	[Level_3Value]			BIT				NOT NULL,
	[Level_3ValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TETCSId] PRIMARY KEY CLUSTERED ([TETCSId] ASC)
);
