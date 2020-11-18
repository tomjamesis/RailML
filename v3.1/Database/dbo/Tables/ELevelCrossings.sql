CREATE TABLE [dbo].[ELevelCrossings]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELevelCrossingsId]	BIGINT		NOT NULL,
	[LevelCrossing]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ELevelCrossingsId] PRIMARY KEY CLUSTERED ([ELevelCrossingsId] ASC),
	CONSTRAINT [FK_ELevelCrossings_ELevelCrossing] FOREIGN KEY ([LevelCrossing]) REFERENCES [dbo].[ELevelCrossing] ([ELevelCrossingId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
