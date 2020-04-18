CREATE TABLE [dbo].[TMechanicalWagonCouplerType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TMechanicalWagonCouplerTypeId]	BIGINT			NOT NULL,
	[DesignType]					NVARCHAR(MAX)	NOT NULL,
	[PositionOnCarEnd]				TINYINT			NOT NULL,
	[CouplingHeightValue]			DECIMAL(18, 6)	NOT NULL,
	[CouplingHeightValueSpecified]	BIT				NOT NULL,
	[PullingForceValue]			DECIMAL(18, 6)	NOT NULL,
	[PullingForceValueSpecified]	BIT				NOT NULL,
	[PushingForceValue]			DECIMAL(18, 6)	NOT NULL,
	[PushingForceValueSpecified]	BIT				NOT NULL,

	CONSTRAINT [PK_TMechanicalWagonCouplerTypeId] PRIMARY KEY CLUSTERED ([TMechanicalWagonCouplerTypeId] ASC),
	CONSTRAINT [FK_TMechanicalWagonCouplerType_TEndPositionType] FOREIGN KEY ([PositionOnCarEnd]) REFERENCES [dbo].[TEndPositionType] ([TEndPositionTypeId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
