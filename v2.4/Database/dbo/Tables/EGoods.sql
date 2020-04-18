CREATE TABLE [dbo].[EGoods]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EGoodsId]	SMALLINT		NOT NULL,
	[Service]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EGoodsId] PRIMARY KEY CLUSTERED ([EGoodsId] ASC),
	CONSTRAINT [FK_EGoods_TService] FOREIGN KEY ([Service]) REFERENCES [dbo].[TService] ([TServiceId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
