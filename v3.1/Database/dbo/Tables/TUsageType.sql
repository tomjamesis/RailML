CREATE TABLE [dbo].[TUsageType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TUsageTypeId]	TINYINT		NOT NULL,
	[Value]		NVARCHAR(9)	NOT NULL,

	CONSTRAINT [PK_TUsageTypeId] PRIMARY KEY CLUSTERED ([TUsageTypeId] ASC)
);
