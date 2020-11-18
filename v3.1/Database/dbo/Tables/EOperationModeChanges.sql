CREATE TABLE [dbo].[EOperationModeChanges]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOperationModeChangesId]	BIGINT		NOT NULL,
	[OperationModeChange]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOperationModeChangesId] PRIMARY KEY CLUSTERED ([EOperationModeChangesId] ASC),
	CONSTRAINT [FK_EOperationModeChanges_TOperationModeChange] FOREIGN KEY ([OperationModeChange]) REFERENCES [dbo].[TOperationModeChange] ([TOperationModeChangeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
