CREATE TABLE [dbo].[TTrainPartRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainPartRefId]	SMALLINT			NOT NULL,
	[Position]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTrainPartRefId] PRIMARY KEY CLUSTERED ([TTrainPartRefId] ASC)
);
