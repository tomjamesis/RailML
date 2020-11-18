CREATE TABLE [dbo].[TRadiusChange]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TRadiusChangeId]				SMALLINT			NOT NULL,
	[Radius]						DECIMAL(18, 6)	NOT NULL,
	[SuperelevationValue]			DECIMAL(18, 6)	NOT NULL,
	[SuperelevationValueSpecified]	BIT				NOT NULL,
	[GeometryElementDescription]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TRadiusChangeId] PRIMARY KEY CLUSTERED ([TRadiusChangeId] ASC)
);
