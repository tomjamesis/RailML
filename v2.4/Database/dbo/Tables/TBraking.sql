CREATE TABLE [dbo].[TBraking]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TBrakingId]								BIGINT			NOT NULL,
	[BrakeType]								NVARCHAR(MAX)	NOT NULL,
	[AirBrakeApplicationPositionValue]			TINYINT			NOT NULL,
	[AirBrakeApplicationPositionValueSpecified]	BIT				NOT NULL,
	[MinimumBrakePercentage]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TBrakingId] PRIMARY KEY CLUSTERED ([TBrakingId] ASC),
	CONSTRAINT [FK_TBraking_TAirBrakeApplicationPosition] FOREIGN KEY ([AirBrakeApplicationPositionValue]) REFERENCES [dbo].[TAirBrakeApplicationPosition] ([TAirBrakeApplicationPositionId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
