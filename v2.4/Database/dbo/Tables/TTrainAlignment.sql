CREATE TABLE [dbo].[TTrainAlignment]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTrainAlignmentId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(6)	NOT NULL,

	CONSTRAINT [PK_TTrainAlignmentId] PRIMARY KEY CLUSTERED ([TTrainAlignmentId] ASC)
);
