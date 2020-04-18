CREATE TABLE [dbo].[EStorage]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EStorageId]	SMALLINT		NOT NULL,
	[Efficiency]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EStorageId] PRIMARY KEY CLUSTERED ([EStorageId] ASC),
	CONSTRAINT [FK_EStorage_TEfficiencyCurve] FOREIGN KEY ([Efficiency]) REFERENCES [dbo].[TEfficiencyCurve] ([TEfficiencyCurveId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
