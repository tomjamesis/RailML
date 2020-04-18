CREATE TABLE [dbo].[TBrakeUse]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBrakeUseId]	TINYINT		NOT NULL,
	[Value]	NVARCHAR(9)	NOT NULL,

	CONSTRAINT [PK_TBrakeUseId] PRIMARY KEY CLUSTERED ([TBrakeUseId] ASC)
);
