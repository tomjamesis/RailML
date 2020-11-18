CREATE TABLE [dbo].[ETrainPartSequence]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[ETrainPartSequenceId]	SMALLINT		NOT NULL,
	[TrainPartRef]			SMALLINT		NOT NULL,
	[SpeedProfileRef]		SMALLINT		NOT NULL,
	[EquipmentUsage]		BIGINT		NOT NULL,
	[BrakeUsage]			SMALLINT		NOT NULL,
	[TopologyReference]	BIGINT		NOT NULL,

	CONSTRAINT [PK_ETrainPartSequenceId] PRIMARY KEY CLUSTERED ([ETrainPartSequenceId] ASC),
	CONSTRAINT [FK_ETrainPartSequence_TTrainPartRef] FOREIGN KEY ([TrainPartRef]) REFERENCES [dbo].[TTrainPartRef] ([TTrainPartRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPartSequence_TSpeedProfileRef] FOREIGN KEY ([SpeedProfileRef]) REFERENCES [dbo].[TSpeedProfileRef] ([TSpeedProfileRefId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPartSequence_TTopologyReference] FOREIGN KEY ([TopologyReference]) REFERENCES [dbo].[TTopologyReference] ([TTopologyReferenceId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPartSequence_EEquipmentUsage] FOREIGN KEY ([EquipmentUsage]) REFERENCES [dbo].[EEquipmentUsage] ([EEquipmentUsageId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_ETrainPartSequence_EBrakeUsage] FOREIGN KEY ([BrakeUsage]) REFERENCES [dbo].[EBrakeUsage] ([EBrakeUsageId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
