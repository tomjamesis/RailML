CREATE TABLE [dbo].[EReplacementOf]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EReplacementOfId]	BIGINT		NOT NULL,
	[OperatingPeriodRef]	SMALLINT		NOT NULL,
	[TafTapTsiTrainID]	SMALLINT		NOT NULL,
	[UniqueTrainKey]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EReplacementOfId] PRIMARY KEY CLUSTERED ([EReplacementOfId] ASC),
	CONSTRAINT [FK_EReplacementOf_TOperatingPeriodRef] FOREIGN KEY ([OperatingPeriodRef]) REFERENCES [dbo].[TOperatingPeriodRef] ([TOperatingPeriodRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EReplacementOf_ETapTsiTransportOperationalIdentifier] FOREIGN KEY ([TafTapTsiTrainID]) REFERENCES [dbo].[ETapTsiTransportOperationalIdentifier] ([ETapTsiTransportOperationalIdentifierId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EReplacementOf_TUniqueTrainKey] FOREIGN KEY ([UniqueTrainKey]) REFERENCES [dbo].[TUniqueTrainKey] ([TUniqueTrainKeyId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
