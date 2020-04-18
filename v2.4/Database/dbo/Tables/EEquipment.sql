CREATE TABLE [dbo].[EEquipment]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EEquipmentId]	SMALLINT		NOT NULL,
	[Etcs]			BIGINT		NOT NULL,

	CONSTRAINT [PK_EEquipmentId] PRIMARY KEY CLUSTERED ([EEquipmentId] ASC),
	CONSTRAINT [FK_EEquipment_TEtcsTT] FOREIGN KEY ([Etcs]) REFERENCES [dbo].[TEtcsTT] ([TEtcsTTId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
