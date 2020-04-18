CREATE TABLE [dbo].[TEtcsTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEtcsTTId]			BIGINT			NOT NULL,
	[SrsVersion]			NVARCHAR(MAX)	NOT NULL,
	[Level_0Value]			BIT				NOT NULL,
	[Level_0ValueSpecified]	BIT				NOT NULL,
	[Level_1Value]			BIT				NOT NULL,
	[Level_1ValueSpecified]	BIT				NOT NULL,
	[Level_2Value]			BIT				NOT NULL,
	[Level_2ValueSpecified]	BIT				NOT NULL,
	[Level_3Value]			BIT				NOT NULL,
	[Level_3ValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TEtcsTTId] PRIMARY KEY CLUSTERED ([TEtcsTTId] ASC)
);
