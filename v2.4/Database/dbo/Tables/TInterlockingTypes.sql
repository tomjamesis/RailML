CREATE TABLE [dbo].[TInterlockingTypes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TInterlockingTypesId]	TINYINT		NOT NULL,
	[Value]				NVARCHAR(18)	NOT NULL,

	CONSTRAINT [PK_TInterlockingTypesId] PRIMARY KEY CLUSTERED ([TInterlockingTypesId] ASC)
);
