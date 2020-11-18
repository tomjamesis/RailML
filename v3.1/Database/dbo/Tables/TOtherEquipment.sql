CREATE TABLE [dbo].[TOtherEquipment]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOtherEquipmentId]	SMALLINT			NOT NULL,
	[OnBoardUnitID]	NVARCHAR(MAX)	NOT NULL,
	[SoftwareVersion]	NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TOtherEquipmentId] PRIMARY KEY CLUSTERED ([TOtherEquipmentId] ASC)
);
