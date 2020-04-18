CREATE TABLE [dbo].[EOcpPropEquipment]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EOcpPropEquipmentId]	BIGINT		NOT NULL,
	[Summary]			BIGINT		NOT NULL,
	[TrackRef]			SMALLINT		NOT NULL,

	CONSTRAINT [PK_EOcpPropEquipmentId] PRIMARY KEY CLUSTERED ([EOcpPropEquipmentId] ASC),
	CONSTRAINT [FK_EOcpPropEquipment_TTrackRefInGroup] FOREIGN KEY ([TrackRef]) REFERENCES [dbo].[TTrackRefInGroup] ([TTrackRefInGroupId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EOcpPropEquipment_TOcpPropEquipmentSummary] FOREIGN KEY ([Summary]) REFERENCES [dbo].[TOcpPropEquipmentSummary] ([TOcpPropEquipmentSummaryId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
