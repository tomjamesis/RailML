CREATE TABLE [dbo].[TRollingstock]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRollingstockId]	SMALLINT			NOT NULL,
	[TimetableRef]		NVARCHAR(MAX)	NOT NULL,
	[InfrastructureRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRollingstockId] PRIMARY KEY CLUSTERED ([TRollingstockId] ASC)
);
