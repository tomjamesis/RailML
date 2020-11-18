CREATE TABLE [dbo].[TSignalCatenary]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSignalCatenaryId]	SMALLINT			NOT NULL,
	[TrackConditionRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSignalCatenaryId] PRIMARY KEY CLUSTERED ([TSignalCatenaryId] ASC)
);
