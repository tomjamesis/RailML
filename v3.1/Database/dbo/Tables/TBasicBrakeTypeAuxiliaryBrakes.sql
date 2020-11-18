CREATE TABLE [dbo].[TBasicBrakeTypeAuxiliaryBrakes]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBasicBrakeTypeAuxiliaryBrakesId]	BIGINT		NOT NULL,
	[BrakeUseValue]					TINYINT		NOT NULL,
	[BrakeUseValueSpecified]			BIT			NOT NULL,
	[HValue]							BIT			NOT NULL,
	[HValueSpecified]					BIT			NOT NULL,
	[EValue]							BIT			NOT NULL,
	[EValueSpecified]					BIT			NOT NULL,
	[MgValue]							BIT			NOT NULL,
	[MgValueSpecified]					BIT			NOT NULL,
	[WbValue]							BIT			NOT NULL,
	[WbValueSpecified]					BIT			NOT NULL,
	[EpValue]							BIT			NOT NULL,
	[EpValueSpecified]					BIT			NOT NULL,

	CONSTRAINT [PK_TBasicBrakeTypeAuxiliaryBrakesId] PRIMARY KEY CLUSTERED ([TBasicBrakeTypeAuxiliaryBrakesId] ASC),
	CONSTRAINT [FK_TBasicBrakeTypeAuxiliaryBrakes_TBrakeUse] FOREIGN KEY ([BrakeUseValue]) REFERENCES [dbo].[TBrakeUse] ([TBrakeUseId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
