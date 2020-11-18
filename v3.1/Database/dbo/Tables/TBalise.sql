CREATE TABLE [dbo].[TBalise]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBaliseId]							SMALLINT			NOT NULL,
	[CountryID]							NVARCHAR(MAX)	NOT NULL,
	[GroupID]								NVARCHAR(MAX)	NOT NULL,
	[LinkingAccuracy]						NVARCHAR(MAX)	NOT NULL,
	[LinkReactionAscendingValue]			TINYINT			NOT NULL,
	[LinkReactionAscendingValueSpecified]	BIT				NOT NULL,
	[LinkReactionDescendingValue]			TINYINT			NOT NULL,
	[LinkReactionDescendingValueSpecified]	BIT				NOT NULL,
	[StaticTelegram]						NVARCHAR(MAX)	NOT NULL,
	[Ndx]									NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBaliseId] PRIMARY KEY CLUSTERED ([TBaliseId] ASC),
	CONSTRAINT [FK_TBalise_TBaliseLinkReaction] FOREIGN KEY ([LinkReactionAscendingValue]) REFERENCES [dbo].[TBaliseLinkReaction] ([TBaliseLinkReactionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
