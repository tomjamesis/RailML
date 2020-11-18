CREATE TABLE [dbo].[TBasicBrakeType]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBasicBrakeTypeId]						BIGINT			NOT NULL,
	[AuxiliaryBrakes]							BIGINT			NOT NULL,
	[BrakeType]								NVARCHAR(MAX)	NOT NULL,
	[AirBrakeApplicationPositionValue]			TINYINT			NOT NULL,
	[AirBrakeApplicationPositionValueSpecified]	BIT				NOT NULL,
	[RegularBrakeMassValue]					DECIMAL(18, 6)	NOT NULL,
	[RegularBrakeMassValueSpecified]			BIT				NOT NULL,
	[EmergencyBrakeMassValue]					DECIMAL(18, 6)	NOT NULL,
	[EmergencyBrakeMassValueSpecified]			BIT				NOT NULL,
	[MaxDecelerationValue]						DECIMAL(18, 6)	NOT NULL,
	[MaxDecelerationValueSpecified]			BIT				NOT NULL,
	[MeanDecelerationValue]					DECIMAL(18, 6)	NOT NULL,
	[MeanDecelerationValueSpecified]			BIT				NOT NULL,

	CONSTRAINT [PK_TBasicBrakeTypeId] PRIMARY KEY CLUSTERED ([TBasicBrakeTypeId] ASC),
	CONSTRAINT [FK_TBasicBrakeType_TBasicBrakeTypeAuxiliaryBrakes] FOREIGN KEY ([AuxiliaryBrakes]) REFERENCES [dbo].[TBasicBrakeTypeAuxiliaryBrakes] ([TBasicBrakeTypeAuxiliaryBrakesId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TBasicBrakeType_TAirBrakeApplicationPosition] FOREIGN KEY ([AirBrakeApplicationPositionValue]) REFERENCES [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
