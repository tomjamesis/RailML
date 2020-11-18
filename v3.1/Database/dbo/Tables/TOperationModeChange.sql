CREATE TABLE [dbo].[TOperationModeChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOperationModeChangeId]	SMALLINT			NOT NULL,
	[ModeLegislative]		NVARCHAR(MAX)	NOT NULL,
	[ModeExecutive]		NVARCHAR(MAX)	NOT NULL,
	[ClearanceManaging]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOperationModeChangeId] PRIMARY KEY CLUSTERED ([TOperationModeChangeId] ASC)
);
