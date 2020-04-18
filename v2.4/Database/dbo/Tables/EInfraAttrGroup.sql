CREATE TABLE [dbo].[EInfraAttrGroup]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EInfraAttrGroupId]	BIGINT		NOT NULL,
	[InfraAttributes]	SMALLINT		NOT NULL,

	CONSTRAINT [PK_EInfraAttrGroupId] PRIMARY KEY CLUSTERED ([EInfraAttrGroupId] ASC),
	CONSTRAINT [FK_EInfraAttrGroup_EInfraAttr] FOREIGN KEY ([InfraAttributes]) REFERENCES [dbo].[EInfraAttr] ([EInfraAttrId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
