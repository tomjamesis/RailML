CREATE TABLE [dbo].[TValueTableValueLineValues]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TValueTableValueLineValuesId]	BIGINT		NOT NULL,
	[YValue]						DECIMAL(18, 6)	NOT NULL,

	CONSTRAINT [PK_TValueTableValueLineValuesId] PRIMARY KEY CLUSTERED ([TValueTableValueLineValuesId] ASC)
);
