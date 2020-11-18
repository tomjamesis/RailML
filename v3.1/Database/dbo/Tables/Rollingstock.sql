CREATE TABLE [dbo].[Rollingstock]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[RollingstockId]	SMALLINT		NOT NULL,
	[Vehicles]		BIGINT		NOT NULL,
	[Formations]	BIGINT		NOT NULL,

	CONSTRAINT [PK_RollingstockId] PRIMARY KEY CLUSTERED ([RollingstockId] ASC),
	CONSTRAINT [FK_Rollingstock_EVehicles] FOREIGN KEY ([Vehicles]) REFERENCES [dbo].[EVehicles] ([EVehiclesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_Rollingstock_EFormations] FOREIGN KEY ([Formations]) REFERENCES [dbo].[EFormations] ([EFormationsId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
