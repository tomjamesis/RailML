CREATE TABLE [dbo].[EPulsePattern]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EPulsePatternId]	BIGINT		NOT NULL,
	[ValueTable]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EPulsePatternId] PRIMARY KEY CLUSTERED ([EPulsePatternId] ASC),
	CONSTRAINT [FK_EPulsePattern_EPulsePatternValueTable] FOREIGN KEY ([ValueTable]) REFERENCES [dbo].[EPulsePatternValueTable] ([EPulsePatternValueTableId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
