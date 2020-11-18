CREATE TABLE [dbo].[ETractionInverter]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETractionInverterId]	SMALLINT		NOT NULL,
	[Efficiency]		SMALLINT		NOT NULL,
	[PulsePattern]		BIGINT		NOT NULL,

	CONSTRAINT [PK_ETractionInverterId] PRIMARY KEY CLUSTERED ([ETractionInverterId] ASC),
	CONSTRAINT [FK_ETractionInverter_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETractionInverter_EPulsePattern] FOREIGN KEY ([PulsePattern]) REFERENCES [dbo].[EPulsePattern] ([EPulsePatternId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
