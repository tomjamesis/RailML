CREATE TABLE [dbo].[TRelatedPositionType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRelatedPositionTypeId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TRelatedPositionTypeId] PRIMARY KEY CLUSTERED ([TRelatedPositionTypeId] ASC)
);
