CREATE TABLE [dbo].[EAuxiliarySupply]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EAuxiliarySupplyId]	SMALLINT		NOT NULL,
	[DedicatedSupplySystem]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EAuxiliarySupplyId] PRIMARY KEY CLUSTERED ([EAuxiliarySupplyId] ASC),
	CONSTRAINT [FK_EAuxiliarySupply_TAuxiliarySupplySystem] FOREIGN KEY ([DedicatedSupplySystem]) REFERENCES [dbo].[TAuxiliarySupplySystem] ([TAuxiliarySupplySystemId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
