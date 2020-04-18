CREATE TABLE [dbo].[TCabPositionType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCabPositionTypeId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(6)	NOT NULL,

	CONSTRAINT [PK_TCabPositionTypeId] PRIMARY KEY CLUSTERED ([TCabPositionTypeId] ASC)
);
