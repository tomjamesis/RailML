CREATE TABLE [dbo].[TValueTableValueLine]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TValueTableValueLineId]	BIGINT		NOT NULL,
	[Values]				BIGINT		NOT NULL,
	[XValue]				DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TValueTableValueLineId] PRIMARY KEY CLUSTERED ([TValueTableValueLineId] ASC),
	CONSTRAINT [FK_TValueTableValueLine_TValueTableValueLineValues] FOREIGN KEY ([Values]) REFERENCES [dbo].[TValueTableValueLineValues] ([TValueTableValueLineValuesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
