CREATE TABLE [dbo].[EConnectionTT]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EConnectionTTId]	SMALLINT		NOT NULL,
	[ExternalReference]	BIGINT		NOT NULL,
	[AnnotationRef]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EConnectionTTId] PRIMARY KEY CLUSTERED ([EConnectionTTId] ASC),
	CONSTRAINT [FK_EConnectionTT_TAnnotationRef] FOREIGN KEY ([AnnotationRef]) REFERENCES [dbo].[TAnnotationRef] ([TAnnotationRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EConnectionTT_EExternalReference] FOREIGN KEY ([ExternalReference]) REFERENCES [dbo].[EExternalReference] ([EExternalReferenceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
