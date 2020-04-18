CREATE TABLE [dbo].[TGoods]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TGoodsId]				BIGINT			NOT NULL,
	[LoadValue]			DECIMAL(18, 6)	NOT NULL,
	[LoadValueSpecified]	BIT				NOT NULL,
	[LoadAreaValue]		DECIMAL(18, 6)	NOT NULL,
	[LoadAreaValueSpecified]	BIT				NOT NULL,
	[VolumeValue]			DECIMAL(18, 6)	NOT NULL,
	[VolumeValueSpecified]	BIT				NOT NULL,
	[FreightCarType]		NVARCHAR(MAX)	NOT NULL,
	[FreightCarUICType]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TGoodsId] PRIMARY KEY CLUSTERED ([TGoodsId] ASC)
);
