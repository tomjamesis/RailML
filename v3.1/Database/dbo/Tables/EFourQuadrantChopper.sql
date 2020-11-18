CREATE TABLE [dbo].[EFourQuadrantChopper]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EFourQuadrantChopperId]	SMALLINT		NOT NULL,
	[Efficiency]			SMALLINT		NOT NULL,
	[Phi]					BIGINT		NOT NULL,

	CONSTRAINT [PK_EFourQuadrantChopperId] PRIMARY KEY CLUSTERED ([EFourQuadrantChopperId] ASC),
	CONSTRAINT [FK_EFourQuadrantChopper_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EFourQuadrantChopper_TCurve] FOREIGN KEY ([Phi]) REFERENCES [dbo].[TCurve] ([TCurveId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
