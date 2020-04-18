CREATE TABLE [dbo].[TSpeedProfile]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TSpeedProfileId]			SMALLINT			NOT NULL,
	[Tilting]					BIGINT			NOT NULL,
	[Braking]					BIGINT			NOT NULL,
	[Path]						BIGINT			NOT NULL,
	[Influence]				NVARCHAR(MAX)	NOT NULL,
	[MaxAxleLoadValue]			DECIMAL(18, 6)	NOT NULL,
	[MaxAxleLoadValueSpecified]BIT				NOT NULL,
	[MaxMeterLoadValue]		DECIMAL(18, 6)	NOT NULL,
	[MaxMeterLoadValueSpecified]	BIT				NOT NULL,
	[OperatingPeriodRef]		NVARCHAR(MAX)	NOT NULL,
	[StartTimeValue]			DATETIME			NOT NULL,
	[StartTimeValueSpecified]	BIT				NOT NULL,
	[EndTimeValue]				DATETIME			NOT NULL,
	[EndTimeValueSpecified]	BIT				NOT NULL,
	[EndDayOffset]				NVARCHAR(MAX)	NOT NULL,
	[TrainProtectionSystem]	NVARCHAR(MAX)	NOT NULL,
	[VerbalConstraint]			NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TSpeedProfileId] PRIMARY KEY CLUSTERED ([TSpeedProfileId] ASC),
	CONSTRAINT [FK_TSpeedProfile_TTilting] FOREIGN KEY ([Tilting]) REFERENCES [dbo].[TTilting] ([TTiltingId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TSpeedProfile_TBraking] FOREIGN KEY ([Braking]) REFERENCES [dbo].[TBraking] ([TBrakingId]), --ON UPDATE CASCADE, ON DELETE CASCADE,
	CONSTRAINT [FK_TSpeedProfile_TPath] FOREIGN KEY ([Path]) REFERENCES [dbo].[TPath] ([TPathId]) --ON UPDATE CASCADE, ON DELETE CASCADE,
);
