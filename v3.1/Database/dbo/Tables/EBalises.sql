CREATE TABLE [dbo].[EBalises]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EBalisesId]BIGINT		NOT NULL,
	[Balise]	SMALLINT		NOT NULL,
	[BaliseGroup]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EBalisesId] PRIMARY KEY CLUSTERED ([EBalisesId] ASC),
	CONSTRAINT [FK_EBalises_TBalise] FOREIGN KEY ([Balise]) REFERENCES [dbo].[TBalise] ([TBaliseId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EBalises_TBaliseGroup] FOREIGN KEY ([BaliseGroup]) REFERENCES [dbo].[TBaliseGroup] ([TBaliseGroupId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
