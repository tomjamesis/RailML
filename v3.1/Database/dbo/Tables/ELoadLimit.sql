CREATE TABLE [dbo].[ELoadLimit]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ELoadLimitId]		SMALLINT		NOT NULL,
	[RailNetwork]		BIGINT		NOT NULL,
	[LineClassification]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ELoadLimitId] PRIMARY KEY CLUSTERED ([ELoadLimitId] ASC),
	CONSTRAINT [FK_ELoadLimit_TRailNetwork] FOREIGN KEY ([RailNetwork]) REFERENCES [dbo].[TRailNetwork] ([TRailNetworkId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ELoadLimit_TLineClassification] FOREIGN KEY ([LineClassification]) REFERENCES [dbo].[TLineClassification] ([TLineClassificationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
