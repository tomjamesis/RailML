CREATE TABLE [dbo].[EWagon]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[EWagonId]				SMALLINT		NOT NULL,
	[Passenger]			SMALLINT		NOT NULL,
	[Goods]				SMALLINT		NOT NULL,
	[AuxiliarySupplySystem]	BIGINT		NOT NULL,
	[DriversCab]			BIGINT		NOT NULL,
	[RackTraction]			BIGINT		NOT NULL,
	[Couplers]				BIGINT		NOT NULL,
	[TrainClearanceGauge]	BIGINT		NOT NULL,

	CONSTRAINT [PK_EWagonId] PRIMARY KEY CLUSTERED ([EWagonId] ASC),
	CONSTRAINT [FK_EWagon_TElectrificationSystem] FOREIGN KEY ([AuxiliarySupplySystem]) REFERENCES [dbo].[TElectrificationSystem] ([TElectrificationSystemId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_TDriversCabType] FOREIGN KEY ([DriversCab]) REFERENCES [dbo].[TDriversCabType] ([TDriversCabTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_TClearanceGaugeType] FOREIGN KEY ([TrainClearanceGauge]) REFERENCES [dbo].[TClearanceGaugeType] ([TClearanceGaugeTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_EPassenger] FOREIGN KEY ([Passenger]) REFERENCES [dbo].[EPassenger] ([EPassengerId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_EGoods] FOREIGN KEY ([Goods]) REFERENCES [dbo].[EGoods] ([EGoodsId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_TRackTractionType] FOREIGN KEY ([RackTraction]) REFERENCES [dbo].[TRackTractionType] ([TRackTractionTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_EWagon_ECouplers] FOREIGN KEY ([Couplers]) REFERENCES [dbo].[ECouplers] ([ECouplersId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
