CREATE TABLE [dbo].[TCurvingLimitationType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TCurvingLimitationTypeId]			BIGINT		NOT NULL,
	[HorizontalCurveRadiusValue]		DECIMAL(18, 6)	NOT NULL,
	[HorizontalCurveRadiusValueSpecified]	BIT			NOT NULL,
	[VerticalCrestRadiusValue]			DECIMAL(18, 6)	NOT NULL,
	[VerticalCrestRadiusValueSpecified]BIT			NOT NULL,
	[VerticalSagRadiusValue]			DECIMAL(18, 6)	NOT NULL,
	[VerticalSagRadiusValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TCurvingLimitationTypeId] PRIMARY KEY CLUSTERED ([TCurvingLimitationTypeId] ASC)
);
