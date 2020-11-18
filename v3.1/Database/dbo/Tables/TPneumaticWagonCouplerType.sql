CREATE TABLE [dbo].[TPneumaticWagonCouplerType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPneumaticWagonCouplerTypeId]				BIGINT			NOT NULL,
	[PositionOnCarEnd]							TINYINT			NOT NULL,
	[CouplerFunction]							NVARCHAR(MAX)	NOT NULL,
	[IntegratedOnMechanicalCouplerValue]		BIT				NOT NULL,
	[IntegratedOnMechanicalCouplerValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TPneumaticWagonCouplerTypeId] PRIMARY KEY CLUSTERED ([TPneumaticWagonCouplerTypeId] ASC),
	CONSTRAINT [FK_TPneumaticWagonCouplerType_TEndPositionType] FOREIGN KEY ([PositionOnCarEnd]) REFERENCES [dbo].[TEndPositionType] ([TEndPositionTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
