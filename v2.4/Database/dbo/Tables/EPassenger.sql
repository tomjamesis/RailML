CREATE TABLE [dbo].[EPassenger]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPassengerId]	SMALLINT		NOT NULL,
	[Gangway]		BIGINT		NOT NULL,
	[Doors]		SMALLINT		NOT NULL,
	[Tilting]		BIGINT		NOT NULL,

	CONSTRAINT [PK_EPassengerId] PRIMARY KEY CLUSTERED ([EPassengerId] ASC),
	CONSTRAINT [FK_EPassenger_TGangway] FOREIGN KEY ([Gangway]) REFERENCES [dbo].[TGangway] ([TGangwayId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EPassenger_EDoors] FOREIGN KEY ([Doors]) REFERENCES [dbo].[EDoors] ([EDoorsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EPassenger_TTilting] FOREIGN KEY ([Tilting]) REFERENCES [dbo].[TTilting] ([TTiltingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
