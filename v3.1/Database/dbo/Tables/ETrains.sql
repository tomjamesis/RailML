CREATE TABLE [dbo].[ETrains]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainsId]	BIGINT		NOT NULL,
	[Train]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETrainsId] PRIMARY KEY CLUSTERED ([ETrainsId] ASC),
	CONSTRAINT [FK_ETrains_ETrain] FOREIGN KEY ([Train]) REFERENCES [dbo].[ETrain] ([ETrainId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
