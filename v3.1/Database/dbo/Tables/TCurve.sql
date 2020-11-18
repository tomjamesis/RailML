CREATE TABLE [dbo].[TCurve]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCurveId]	BIGINT			NOT NULL,
	[Any]		VARCHAR(MAX)		NOT NULL,
	[ValueTable]	SMALLINT			NOT NULL,

	CONSTRAINT [PK_TCurveId] PRIMARY KEY CLUSTERED ([TCurveId] ASC),
	CONSTRAINT [FK_TCurve_TCurveValueTable] FOREIGN KEY ([ValueTable]) REFERENCES [dbo].[TCurveValueTable] ([TCurveValueTableId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
