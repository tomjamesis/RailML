CREATE TABLE [dbo].[TVehicleRef]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TVehicleRefId]			BIGINT			NOT NULL,
	[OrderNumber]				NVARCHAR(MAX)	NOT NULL,
	[VehicleRef]				NVARCHAR(MAX)	NOT NULL,
	[VehicleCount]				NVARCHAR(MAX)	NOT NULL,
	[FrontGangwayValue]		BIT				NOT NULL,
	[FrontGangwayValueSpecified]	BIT				NOT NULL,
	[RearGangwayValue]			BIT				NOT NULL,
	[RearGangwayValueSpecified]BIT				NOT NULL,

	CONSTRAINT [PK_TVehicleRefId] PRIMARY KEY CLUSTERED ([TVehicleRefId] ASC)
);
