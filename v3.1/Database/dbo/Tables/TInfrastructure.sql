CREATE TABLE [dbo].[TInfrastructure]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TInfrastructureId]	SMALLINT			NOT NULL,
	[TimetableRef]		NVARCHAR(MAX)	NOT NULL,
	[RollingstockRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TInfrastructureId] PRIMARY KEY CLUSTERED ([TInfrastructureId] ASC)
);
