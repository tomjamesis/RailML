CREATE TABLE [dbo].[EAnnotations]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EAnnotationsId]	BIGINT		NOT NULL,
	[Annotation]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EAnnotationsId] PRIMARY KEY CLUSTERED ([EAnnotationsId] ASC),
	CONSTRAINT [FK_EAnnotations_EAnnotation] FOREIGN KEY ([Annotation]) REFERENCES [dbo].[EAnnotation] ([EAnnotationId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
