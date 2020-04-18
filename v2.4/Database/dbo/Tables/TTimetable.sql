CREATE TABLE [dbo].[TTimetable]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TTimetableId]		SMALLINT			NOT NULL,
	[InfrastructureRef]	NVARCHAR(MAX)	NOT NULL,
	[RollingstockRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TTimetableId] PRIMARY KEY CLUSTERED ([TTimetableId] ASC)
);
