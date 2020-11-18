CREATE TABLE [dbo].[ETransformer]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETransformerId]	SMALLINT		NOT NULL,
	[Winding]		BIGINT		NOT NULL,
	[Efficiency]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_ETransformerId] PRIMARY KEY CLUSTERED ([ETransformerId] ASC),
	CONSTRAINT [FK_ETransformer_TWinding] FOREIGN KEY ([Winding]) REFERENCES [dbo].[TWinding] ([TWindingId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETransformer_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
