CREATE TABLE [dbo].[TDoors]
(
	--From MergedXSDs XSD
	--From 'genericRailML' Namespace
	[TDoorsId]						BIGINT			NOT NULL,
	[Number]						NVARCHAR(MAX)	NOT NULL,
	[EntranceHeightValue]			DECIMAL(18, 6)	NOT NULL,
	[EntranceHeightValueSpecified]	BIT				NOT NULL,
	[EntranceLengthValue]			DECIMAL(18, 6)	NOT NULL,
	[EntranceLengthValueSpecified]	BIT				NOT NULL,
	[EntranceWidthValue]			DECIMAL(18, 6)	NOT NULL,
	[EntranceWidthValueSpecified]	BIT				NOT NULL,
	[FootStepHeightValue]			DECIMAL(18, 6)	NOT NULL,
	[FootStepHeightValueSpecified]	BIT				NOT NULL,
	[LockingSpeedValue]			DECIMAL(18, 6)	NOT NULL,
	[LockingSpeedValueSpecified]	BIT				NOT NULL,
	[OpeningTime]					NVARCHAR(MAX)	NOT NULL,
	[ClosingTime]					NVARCHAR(MAX)	NOT NULL,

	CONSTRAINT [PK_TDoorsId] PRIMARY KEY CLUSTERED ([TDoorsId] ASC)
);
