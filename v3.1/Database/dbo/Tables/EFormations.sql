CREATE TABLE [dbo].[EFormations]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EFormationsId]	BIGINT		NOT NULL,
	[Formation]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EFormationsId] PRIMARY KEY CLUSTERED ([EFormationsId] ASC),
	CONSTRAINT [FK_EFormations_EFormation] FOREIGN KEY ([Formation]) REFERENCES [dbo].[EFormation] ([EFormationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
