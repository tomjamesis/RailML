CREATE TABLE [dbo].[ECirculations]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ECirculationsId]	BIGINT		NOT NULL,
	[Circulation]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ECirculationsId] PRIMARY KEY CLUSTERED ([ECirculationsId] ASC),
	CONSTRAINT [FK_ECirculations_TCirculation] FOREIGN KEY ([Circulation]) REFERENCES [dbo].[TCirculation] ([TCirculationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
