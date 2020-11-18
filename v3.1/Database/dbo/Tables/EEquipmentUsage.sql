CREATE TABLE [dbo].[EEquipmentUsage]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EEquipmentUsageId]	BIGINT		NOT NULL,
	[Equipment]		SMALLINT		NOT NULL,

	CONSTRAINT [PK_EEquipmentUsageId] PRIMARY KEY CLUSTERED ([EEquipmentUsageId] ASC),
	CONSTRAINT [FK_EEquipmentUsage_EEquipment] FOREIGN KEY ([Equipment]) REFERENCES [dbo].[EEquipment] ([EEquipmentId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
