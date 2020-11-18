CREATE TABLE [dbo].[TOcpPropEquipmentSummary]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TOcpPropEquipmentSummaryId]	BIGINT		NOT NULL,
	[SignalBoxValue]			TINYINT		NOT NULL,
	[SignalBoxValueSpecified]	BIT			NOT NULL,
	[Powerstation]				BIT			NOT NULL,
	[HasHomeSignals]			BIT			NOT NULL,
	[HasStarterSignals]		BIT			NOT NULL,
	[HasSwitches]				BIT			NOT NULL,

	CONSTRAINT [PK_TOcpPropEquipmentSummaryId] PRIMARY KEY CLUSTERED ([TOcpPropEquipmentSummaryId] ASC),
	CONSTRAINT [FK_TOcpPropEquipmentSummary_TInterlockingTypes] FOREIGN KEY ([SignalBoxValue]) REFERENCES [dbo].[TInterlockingTypes] ([TInterlockingTypesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
