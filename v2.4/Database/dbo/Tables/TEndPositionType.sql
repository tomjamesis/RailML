CREATE TABLE [dbo].[TEndPositionType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEndPositionTypeId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(5)	NOT NULL,

	CONSTRAINT [PK_TEndPositionTypeId] PRIMARY KEY CLUSTERED ([TEndPositionTypeId] ASC)
);
