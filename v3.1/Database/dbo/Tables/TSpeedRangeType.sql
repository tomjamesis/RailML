CREATE TABLE [dbo].[TSpeedRangeType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpeedRangeTypeId]	TINYINT		NOT NULL,
	[Value]			NVARCHAR(8)	NOT NULL,

	CONSTRAINT [PK_TSpeedRangeTypeId] PRIMARY KEY CLUSTERED ([TSpeedRangeTypeId] ASC)
);
