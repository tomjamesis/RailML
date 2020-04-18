CREATE TABLE [dbo].[EGear]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGearId]	SMALLINT		NOT NULL,
	[Efficiency]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EGearId] PRIMARY KEY CLUSTERED ([EGearId] ASC),
	CONSTRAINT [FK_EGear_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
