CREATE TABLE [dbo].[TOcpPropService]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpPropServiceId]	BIGINT		NOT NULL,
	[Passenger]		BIT			NOT NULL,
	[Service]			BIT			NOT NULL,
	[Ship]				BIT			NOT NULL,
	[Bus]				BIT			NOT NULL,
	[Airport]			BIT			NOT NULL,
	[Tariffpoint]		BIT			NOT NULL,
	[GoodsLoading]		BIT			NOT NULL,
	[GoodsSiding]		BIT			NOT NULL,
	[GoodsIntermodal]	BIT			NOT NULL,
	[GoodsMarshalling]	BIT			NOT NULL,

	CONSTRAINT [PK_TOcpPropServiceId] PRIMARY KEY CLUSTERED ([TOcpPropServiceId] ASC)
);
