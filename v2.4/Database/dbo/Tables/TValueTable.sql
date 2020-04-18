CREATE TABLE [dbo].[TValueTable]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TValueTableId]	BIGINT			NOT NULL,
	[ColumnHeader]	BIGINT			NOT NULL,
	[ValueLine]	BIGINT			NOT NULL,
	[XValueName]	NVARCHAR(MAX)	NOT NULL,
	[XValueUnit]	NVARCHAR(MAX)	NOT NULL,
	[YValueName]	NVARCHAR(MAX)	NOT NULL,
	[YValueUnit]	NVARCHAR(MAX)	NOT NULL,
	[ZValueName]	NVARCHAR(MAX)	NOT NULL,
	[ZValueUnit]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TValueTableId] PRIMARY KEY CLUSTERED ([TValueTableId] ASC),
	CONSTRAINT [FK_TValueTable_TValueTableColumnHeader] FOREIGN KEY ([ColumnHeader]) REFERENCES [dbo].[TValueTableColumnHeader] ([TValueTableColumnHeaderId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TValueTable_TValueTableValueLine] FOREIGN KEY ([ValueLine]) REFERENCES [dbo].[TValueTableValueLine] ([TValueTableValueLineId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
