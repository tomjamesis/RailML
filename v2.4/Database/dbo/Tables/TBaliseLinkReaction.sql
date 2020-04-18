CREATE TABLE [dbo].[TBaliseLinkReaction]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBaliseLinkReactionId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(17)	NOT NULL,

	CONSTRAINT [PK_TBaliseLinkReactionId] PRIMARY KEY CLUSTERED ([TBaliseLinkReactionId] ASC)
);
