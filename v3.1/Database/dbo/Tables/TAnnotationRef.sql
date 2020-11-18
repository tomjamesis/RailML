CREATE TABLE [dbo].[TAnnotationRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TAnnotationRefId]	SMALLINT			NOT NULL,
	[OperatingPeriodRef]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TAnnotationRefId] PRIMARY KEY CLUSTERED ([TAnnotationRefId] ASC)
);
