CREATE TABLE [dbo].[ELoadLimitMatrix]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELoadLimitMatrixId]	SMALLINT		NOT NULL,
	[LoadLimit]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_ELoadLimitMatrixId] PRIMARY KEY CLUSTERED ([ELoadLimitMatrixId] ASC),
	CONSTRAINT [FK_ELoadLimitMatrix_ELoadLimit] FOREIGN KEY ([LoadLimit]) REFERENCES [dbo].[ELoadLimit] ([ELoadLimitId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
