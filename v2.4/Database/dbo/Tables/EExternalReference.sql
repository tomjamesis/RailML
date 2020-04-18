CREATE TABLE [dbo].[EExternalReference]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EExternalReferenceId]	BIGINT		NOT NULL,
	[TafTapTsiTrainID]		SMALLINT		NOT NULL,
	[TrainNumber]			BIGINT		NOT NULL,
	[LineNumber]			BIGINT		NOT NULL,
	[Information]			BIGINT		NOT NULL,

	CONSTRAINT [PK_EExternalReferenceId] PRIMARY KEY CLUSTERED ([EExternalReferenceId] ASC),
	CONSTRAINT [FK_EExternalReference_ETapTsiTransportOperationalIdentifier] FOREIGN KEY ([TafTapTsiTrainID]) REFERENCES [dbo].[ETapTsiTransportOperationalIdentifier] ([ETapTsiTransportOperationalIdentifierId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EExternalReference_EExternalReferenceTrainNumber] FOREIGN KEY ([TrainNumber]) REFERENCES [dbo].[EExternalReferenceTrainNumber] ([EExternalReferenceTrainNumberId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EExternalReference_EExternalReferenceLineNumber] FOREIGN KEY ([LineNumber]) REFERENCES [dbo].[EExternalReferenceLineNumber] ([EExternalReferenceLineNumberId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EExternalReference_EExternalReferenceInformation] FOREIGN KEY ([Information]) REFERENCES [dbo].[EExternalReferenceInformation] ([EExternalReferenceInformationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
