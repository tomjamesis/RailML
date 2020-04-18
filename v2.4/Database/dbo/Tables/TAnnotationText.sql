CREATE TABLE [dbo].[TAnnotationText]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[Value]			NVARCHAR(MAX)	NOT NULL,
	[TAnnotationTextId]	BIGINT			NOT NULL,
	[Lang]				NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TAnnotationTextId] PRIMARY KEY CLUSTERED ([TAnnotationTextId] ASC)
);
