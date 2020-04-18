CREATE TABLE [dbo].[TPassenger]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TPassengerId]								SMALLINT		NOT NULL,
	[DeckValue]								TINYINT		NOT NULL,
	[DeckValueSpecified]						BIT			NOT NULL,
	[DrivingCabValue]							BIT			NOT NULL,
	[DrivingCabValueSpecified]					BIT			NOT NULL,
	[TiltingValue]								BIT			NOT NULL,
	[TiltingValueSpecified]					BIT			NOT NULL,
	[AirTightnessValue]						BIT			NOT NULL,
	[AirTightnessValueSpecified]				BIT			NOT NULL,
	[EmergencyBrakeDeactivationValue]			BIT			NOT NULL,
	[EmergencyBrakeDeactivationValueSpecified]	BIT			NOT NULL,

	CONSTRAINT [PK_TPassengerId] PRIMARY KEY CLUSTERED ([TPassengerId] ASC),
	CONSTRAINT [FK_TPassenger_TVerbalCounter] FOREIGN KEY ([DeckValue]) REFERENCES [dbo].[TVerbalCounter] ([TVerbalCounterId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
