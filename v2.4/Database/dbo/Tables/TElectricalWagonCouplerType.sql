CREATE TABLE [dbo].[TElectricalWagonCouplerType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TElectricalWagonCouplerTypeId]			BIGINT			NOT NULL,
	[PositionOnCarEnd]							TINYINT			NOT NULL,
	[DesignType]								NVARCHAR(MAX)	NOT NULL,
	[PositionOnMechanicalCouplerValue]			TINYINT			NOT NULL,
	[PositionOnMechanicalCouplerValueSpecified]	BIT				NOT NULL,
	[NumberContacts]							NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TElectricalWagonCouplerTypeId] PRIMARY KEY CLUSTERED ([TElectricalWagonCouplerTypeId] ASC),
	CONSTRAINT [FK_TElectricalWagonCouplerType_TEndPositionType] FOREIGN KEY ([PositionOnCarEnd]) REFERENCES [dbo].[TEndPositionType] ([TEndPositionTypeId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TElectricalWagonCouplerType_TRelatedPositionType] FOREIGN KEY ([PositionOnMechanicalCouplerValue]) REFERENCES [dbo].[TRelatedPositionType] ([TRelatedPositionTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
