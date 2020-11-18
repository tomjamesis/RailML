CREATE TABLE [dbo].[TBaliseGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBaliseGroupId]	SMALLINT			NOT NULL,
	[BaliseRef]	SMALLINT			NOT NULL,
	[Type]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBaliseGroupId] PRIMARY KEY CLUSTERED ([TBaliseGroupId] ASC),
	CONSTRAINT [FK_TBaliseGroup_TBaliseRefInGroup] FOREIGN KEY ([BaliseRef]) REFERENCES [dbo].[TBaliseRefInGroup] ([TBaliseRefInGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
