CREATE TABLE [dbo].[TEquipment]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TEquipmentId]		BIGINT			NOT NULL,
	[Any]				VARCHAR(MAX)		NOT NULL,
	[Type]				NVARCHAR(MAX)	NOT NULL,
	[UsesValue]		BIT				NOT NULL,
	[UsesValueSpecified]	BIT				NOT NULL,
	[Description]		NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TEquipmentId] PRIMARY KEY CLUSTERED ([TEquipmentId] ASC)
);
