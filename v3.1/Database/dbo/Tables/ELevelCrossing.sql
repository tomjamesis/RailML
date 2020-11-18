CREATE TABLE [dbo].[ELevelCrossing]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELevelCrossingId]	SMALLINT		NOT NULL,
	[CrossedElements]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ELevelCrossingId] PRIMARY KEY CLUSTERED ([ELevelCrossingId] ASC),
	CONSTRAINT [FK_ELevelCrossing_ECrossedElements] FOREIGN KEY ([CrossedElements]) REFERENCES [dbo].[ECrossedElements] ([ECrossedElementsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
