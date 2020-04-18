CREATE TABLE [dbo].[EAnnotation]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EAnnotationId]	SMALLINT		NOT NULL,
	[Text]			BIGINT		NOT NULL,

	CONSTRAINT [PK_EAnnotationId] PRIMARY KEY CLUSTERED ([EAnnotationId] ASC),
	CONSTRAINT [FK_EAnnotation_TAnnotationText] FOREIGN KEY ([Text]) REFERENCES [dbo].[TAnnotationText] ([TAnnotationTextId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
