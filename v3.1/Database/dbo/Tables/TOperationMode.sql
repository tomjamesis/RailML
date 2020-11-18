CREATE TABLE [dbo].[TOperationMode]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperationModeId]	BIGINT			NOT NULL,
	[ModeLegislative]	NVARCHAR(MAX)	NOT NULL,
	[ModeExecutive]	NVARCHAR(MAX)	NOT NULL,
	[ClearanceManaging]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOperationModeId] PRIMARY KEY CLUSTERED ([TOperationModeId] ASC)
);
