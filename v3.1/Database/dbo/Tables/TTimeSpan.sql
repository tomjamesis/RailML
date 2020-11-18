CREATE TABLE [dbo].[TTimeSpan]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTimeSpanId]	BIGINT		NOT NULL,
	[From]		DATETIME		NOT NULL,
	[Until]	DATETIME		NOT NULL,

	CONSTRAINT [PK_TTimeSpanId] PRIMARY KEY CLUSTERED ([TTimeSpanId] ASC)
);
