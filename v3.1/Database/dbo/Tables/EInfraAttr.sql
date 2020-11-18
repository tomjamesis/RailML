CREATE TABLE [dbo].[EInfraAttr]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EInfraAttrId]			SMALLINT		NOT NULL,
	[Owner]				BIGINT		NOT NULL,
	[OperationMode]		BIGINT		NOT NULL,
	[TrainProtection]		BIGINT		NOT NULL,
	[Electrification]		BIGINT		NOT NULL,
	[PowerTransmission]	BIGINT		NOT NULL,
	[AxleWeight]			BIGINT		NOT NULL,
	[Gauge]				BIGINT		NOT NULL,
	[ClearanceGauge]		BIGINT		NOT NULL,
	[Speeds]				BIGINT		NOT NULL,
	[EpsgCode]				BIGINT		NOT NULL,
	[TrainRadio]			BIGINT		NOT NULL,
	[GeneralInfraAttributes]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EInfraAttrId] PRIMARY KEY CLUSTERED ([EInfraAttrId] ASC),
	CONSTRAINT [FK_EInfraAttr_TOwner] FOREIGN KEY ([Owner]) REFERENCES [dbo].[TOwner] ([TOwnerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TOperationMode] FOREIGN KEY ([OperationMode]) REFERENCES [dbo].[TOperationMode] ([TOperationModeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TTrainProtection] FOREIGN KEY ([TrainProtection]) REFERENCES [dbo].[TTrainProtection] ([TTrainProtectionId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TElectrification] FOREIGN KEY ([Electrification]) REFERENCES [dbo].[TElectrification] ([TElectrificationId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TPowerTransmission] FOREIGN KEY ([PowerTransmission]) REFERENCES [dbo].[TPowerTransmission] ([TPowerTransmissionId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TAxleWeight] FOREIGN KEY ([AxleWeight]) REFERENCES [dbo].[TAxleWeight] ([TAxleWeightId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TGauge] FOREIGN KEY ([Gauge]) REFERENCES [dbo].[TGauge] ([TGaugeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TClearanceGaugeType] FOREIGN KEY ([ClearanceGauge]) REFERENCES [dbo].[TClearanceGaugeType] ([TClearanceGaugeTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_ESpeeds] FOREIGN KEY ([Speeds]) REFERENCES [dbo].[ESpeeds] ([ESpeedsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TEpsgCode] FOREIGN KEY ([EpsgCode]) REFERENCES [dbo].[TEpsgCode] ([TEpsgCodeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_TTrainRadioAttributes] FOREIGN KEY ([TrainRadio]) REFERENCES [dbo].[TTrainRadioAttributes] ([TTrainRadioAttributesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EInfraAttr_EGeneralInfraAttributes] FOREIGN KEY ([GeneralInfraAttributes]) REFERENCES [dbo].[EGeneralInfraAttributes] ([EGeneralInfraAttributesId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
